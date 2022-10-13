using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NITGEN.SDK.NBioBSP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace THM_Acesso
{
    public partial class Main : Form
    {
        string urlApi;
        NBioAPI m_NBioAPI;
        NBioAPI.IndexSearch m_IndexSearch;   
        NBioAPI.IndexSearch.FP_INFO[] fpInfo;
        NBioAPI.Type.HFIR HFirCapturado;
        HttpClient clientHttp;
        dynamic jsonFirs;        

        private async void lbl_msg_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            lbl_msg.Text = "Registre a entrada ou pesquise por CPF";
            lblNome.Text = "";
            lblCPF.Text = "";
            lblDtNascimento.Text = "";
            lblOcupacoes.Text = "";
            lblObservacoes.Text = "";
            pictureFotoPerfil.Image = null;
        }
        public static Image LoadBase64(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }
        /*private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }*/

        public Main()
        {
            urlApi = ConfigurationManager.AppSettings.Get("UrlApi");
            clientHttp = new HttpClient();

            
            InitializeComponent();

            loadFirs();


        }

        public void loadFirs()
        {
            try
            {
                var firs = clientHttp.GetAsync(urlApi + "biometria/dados").Result;

                if ((int)firs.StatusCode == 200)
                {
                    m_NBioAPI = new NBioAPI();
                    m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);

                    m_IndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
                    m_IndexSearch.InitEngine();

                    jsonFirs = JsonConvert.DeserializeObject(firs.Content.ReadAsStringAsync().Result);

                    foreach (var usuario in jsonFirs)
                    {
                        m_IndexSearch.AddFIR(new NBioAPI.Type.FIR_TEXTENCODE
                        {
                            IsWideChar = true,
                            TextFIR = usuario["fir_digital"].ToString()
                        }, uint.Parse(usuario["cd_profissional"].ToString()), out fpInfo);

                    }
                }
                lbl_msg.Text = "Registre a entrada ou pesquise por CPF";
                lblNome.Text = "";
                lblCPF.Text = "";
                lblDtNascimento.Text = "";
                lblOcupacoes.Text = "";
                lblObservacoes.Text = "";
                pictureFotoPerfil.Image = null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu algum erro ao carregar os dados. Procure a TI");
                MessageBox.Show(e.Message);
            }
        }
        private void Main_Activated(object sender, EventArgs e)
        {
            TimerVerifyFinger.Start();
        }

        private void Main_Deactivate(object sender, EventArgs e)
        {
            TimerVerifyFinger.Stop();
        }
        private void TimerVerifyFinger_Tick(object sender, EventArgs e)
        {
            try
            {
                TimerVerifyFinger.Stop();
                
                bool dedoNoSensor;
                m_NBioAPI.CheckFinger(out dedoNoSensor);

                if (dedoNoSensor)
                {
                    NBioAPI.IndexSearch.FP_INFO fpInfo1;
                    NBioAPI.IndexSearch.CALLBACK_INFO_0 CallbackInfo = new NBioAPI.IndexSearch.CALLBACK_INFO_0();
                    bool resultMatch;
                    NBioAPI.Type.FIR_PAYLOAD payload = new NBioAPI.Type.FIR_PAYLOAD();

                    m_NBioAPI.Capture(NBioAPI.Type.FIR_PURPOSE.VERIFY, out HFirCapturado, NBioAPI.Type.TIMEOUT.DEFAULT, null, new NBioAPI.Type.WINDOW_OPTION());

                    m_IndexSearch.IdentifyData(HFirCapturado, 8, out fpInfo1, CallbackInfo);

                    if (Convert.ToInt32(fpInfo1.ID) == 0)
                    {
                        lbl_msg.Text = "Usuario não identificado";
                        TimerVerifyFinger.Interval = 5000;
                        TimerVerifyFinger.Start();
                    }
                    else
                    {
                        foreach (var linha in jsonFirs)
                        {
                            if (linha["cd_profissional"].ToString() == fpInfo1.ID.ToString())
                            {
                                m_NBioAPI.VerifyMatch(HFirCapturado, new NBioAPI.Type.FIR_TEXTENCODE
                                {
                                    IsWideChar = true,
                                    TextFIR = linha["fir_digital"].ToString()
                                }, out resultMatch, payload);

                                if (resultMatch)
                                {
                                    var values = new Dictionary<string, string>
                                    {
                                        { "nr_cpf", payload.Data.Split(char.Parse(" "))[1] },
                                        { "nr_senha", payload.Data.Split(char.Parse(" "))[0] }
                                    };

                                    var response = clientHttp.PostAsync(urlApi + "registraAcesso", new FormUrlEncodedContent(values)).Result;

                                    dynamic contentResponse = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                                    
                                    lbl_msg.Text = contentResponse["mensagem"].mensagem.ToString();

                                    lblNome.Text = contentResponse["usuario"].nm_profissional.ToString();
                                    lblCPF.Text = contentResponse["usuario"].nr_cpf.ToString();
                                    lblDtNascimento.Text = contentResponse["usuario"].dt_nacimento.ToString("dd/MM/yyyy");
                                    lblObservacoes.Text = contentResponse["usuario"].ds_observacoes.ToString();
                                    pictureFotoPerfil.Image = LoadBase64(contentResponse["img"].ToString());

                                    var index = dataGridHistorico.Rows.Add();
                                    dataGridHistorico.Rows[index].Cells[0].Value = lblNome.Text;
                                    dataGridHistorico.Rows[index].Cells[1].Value = lblCPF.Text;
                                    dataGridHistorico.Rows[index].Cells[2].Value = contentResponse["mensagem"].acao.ToString();
                                    //MessageBox.Show(contentResponse["mensagem"].imprime.ToString());
                                    if (contentResponse["mensagem"].imprime.ToString() == "True")
                                    {
                                        dataGridHistorico.Rows[index].Cells[3].ReadOnly = false;
                                    }
                                    else
                                    {
                                        dataGridHistorico.Rows[index].Cells[3].ReadOnly = true;
                                    }

                                    if (contentResponse["mensagem"].prestador.ToString() == "True")
                                    {
                                        dataGridHistorico.Rows[index].Cells[4].Value = true;
                                    }
                                    else
                                    {
                                        dataGridHistorico.Rows[index].Cells[4].Value = false;
                                    }
                                    
                                    /*DataGridViewRow row = (DataGridViewRow)dataGridHistorico.Rows[dataGridHistorico.Rows.Add()].Clone();
                                    row.Cells[0].Value = lblNome.Text;
                                    row.Cells[1].Value = lblCPF.Text; 
                                    row.Cells[2].ReadOnly =true;
                                    dataGridHistorico.Rows.Add(lblNome.Text, lblCPF.Text, "Etiqueta Visitante");
*/
                                    if ((int)response.StatusCode == 200)
                                    {
                                        TimerVerifyFinger.Interval = 4000;
                                        TimerVerifyFinger.Start();
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    TimerVerifyFinger.Interval = 300;
                    TimerVerifyFinger.Start();
                }
            }
            catch (Exception err)
            {
                lbl_msg.Text = "Erro no sistema, procure a equipe de TI!";
                MessageBox.Show(err.ToString());
            }
        }

        

        

        public void dataGridHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.ColumnIndex == dataGridHistorico.Columns["ColumnImprimir"].Index && e.RowIndex >= 0 && dataGridHistorico.Rows[e.RowIndex].Cells[3].ReadOnly == false)
            {
                
                PrintDocument p = new PrintDocument();
                p.PrintPage += delegate (object senderPrint, PrintPageEventArgs ePrint)
                {
                    if (dataGridHistorico.Rows[e.RowIndex].Cells[4].Value.ToString() == "True")
                    {
                        ePrint.Graphics.DrawString("Prestador", new Font("Times New Roman", 12), new SolidBrush(Color.Black), new Point(100, 10));
                    }
                    else
                    {
                        ePrint.Graphics.DrawString("Visitante", new Font("Times New Roman", 12), new SolidBrush(Color.Black), new Point(100, 10));
                    }
                    ePrint.Graphics.DrawString("Nome: " + dataGridHistorico.Rows[e.RowIndex].Cells[0].Value.ToString(), new Font("Times New Roman", 12), new SolidBrush(Color.Black), new Point(10, 25));
                    ePrint.Graphics.DrawString("CPF: " + dataGridHistorico.Rows[e.RowIndex].Cells[1].Value.ToString(), new Font("Times New Roman", 12), new SolidBrush(Color.Black), new Point(10, 40));

                };
                try
                {
                    p.Print();
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception Occured While Printing", ex);
                }
            }
        }



        /*private void btnBuscar_Click(object sender, EventArgs e)
        {
            //verificar digital
            var firs = clientHttp.GetAsync(urlApi + "buscaUsuario/"+ txbCpf.Text).Result;
            var contentResponse = firs.Content.ReadAsStringAsync().Result;

            if ((int)firs.StatusCode == 302)
            {
                if (MessageBox.Show("CPF cadastrado, Deseja Fazer o Registro Manual?", "CPF Cadastrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                }
            }
            else if ((int)firs.StatusCode == 404)
            {
                if (MessageBox.Show("CPF não Cadastrado, Deseja Abrir a Janela de Cadastro ?", "CPF Não Cadastrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Cadastro cad = new Cadastro(txbCpf.Text);
                    cad.Show();
                }
            }
        }*/
    }

}


        

            
        