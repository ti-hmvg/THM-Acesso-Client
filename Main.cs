using Newtonsoft.Json;
using NITGEN.SDK.NBioBSP;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Xml.Linq;

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
        string path;
        DataGridViewRow dataGridViewRowModelo;
        bool resetText;
        private void lbl_msg_TextChanged()
        {
            lbl_msg.Text = "Registre a entrada pela Biometria";
            lblNome.Text = "";
            lblCPF.Text = "";
            lblDtNascimento.Text = "";
            pictureFotoPerfil.Image = null;
        }
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            try
            {
                var dt = new DataTable();

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    dt.Columns.Add(column.Name.Replace("Column", ""), typeof(string));
                }

                object[] cellValues = new object[dgv.Columns.Count];
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        cellValues[i] = row.Cells[i].Value;
                    }
                    dt.Rows.Add(cellValues);
                }

                return dt;

            }
            catch (Exception erro)
            {
                Task.Run(() =>
                {
                    MessageBox.Show("GetDataTableFromDGV" + erro.ToString());
                });
                throw;
            }
        }
        private DataTable GetRowDataTableFromDGV(DataGridView dgv)
        {
            try
            {
                var dt = new DataTable();

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    dt.Columns.Add(column.Name.Replace("Column", ""), typeof(string));
                }

                object[] cellValues = new object[dgv.Columns.Count];

                for (int i = 0; i < dgv.Rows[dgv.Rows.Count - 1].Cells.Count; i++)
                {
                    cellValues[i] = dgv.Rows[dgv.Rows.Count - 1].Cells[i].Value;
                }
                dt.Rows.Add(cellValues);

                return dt;
            }
            catch (Exception erro)
            {
                Task.Run(() =>
                {
                    MessageBox.Show("GetRowDataTableFromDGV" + erro.ToString());
                });
                throw;
            }
            
        }
        public static Image LoadBase64(string base64)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(base64);
                Image image;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    image = Image.FromStream(ms);
                }
                return image;
            }
            catch (Exception erro)
            {
                Task.Run(() =>
                {
                    MessageBox.Show("LoadBase64" + erro.ToString());
                });
                throw;
            }
        }

        public Main()
        {
            urlApi = ConfigurationManager.AppSettings.Get("UrlApi");

            clientHttp = new HttpClient();

            InitializeComponent();

            try
            {
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "THM-Acesso");
                System.IO.Directory.CreateDirectory(path);

                var doc = XDocument.Load(Path.Combine(path, "HistoricoTHMAcesso.xml"));


                if (doc.Descendants("Table1").Count() > 20)
                {
                    for (int i = 5; i <= doc.Descendants("Table1").Count(); i++)
                    {
                        //MessageBox.Show(doc.Descendants("Table1").Count().ToString());
                        var lastFile = doc.Descendants("Table1").LastOrDefault();
                        if (lastFile != null)
                        {
                            lastFile.Remove();
                        }
                    }

                }

                doc.Save(Path.Combine(path, "HistoricoTHMAcesso.xml"));

                DataSet dataSet = new DataSet();



                dataSet.ReadXml(Path.Combine(path, "HistoricoTHMAcesso.xml"));

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    var index = dataGridHistorico.Rows.Add();
                    dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["ColumnNome"].Index].Value = row["Nome"].ToString();
                    dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["ColumnCPF"].Index].Value = row["CPF"].ToString();
                    dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["ColumnAcao"].Index].Value = row["Acao"].ToString();
                    dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["DataNascimento"].Index].Value = row["DataNascimento"].ToString();
                    dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["ColumnHorario"].Index].Value = row["Horario"].ToString();
                    if (row["Imprime"].ToString() == "True")
                    {
                        dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["ColumnImprimir"].Index].ReadOnly = false;
                        dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["ColumnImprime"].Index].Value = true;
                    }
                    else
                    {
                        dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["ColumnImprimir"].Index].ReadOnly = true;
                        dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["ColumnImprime"].Index].Value = false;
                    }

                    if (row["Prestador"].ToString() == "True")
                    {
                        dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["ColumnPrestador"].Index].Value = true;
                    }
                    else
                    {
                        dataGridHistorico.Rows[index].Cells[dataGridHistorico.Columns["ColumnPrestador"].Index].Value = false;
                    }

                }

            }
            catch (Exception err)
            {
                Task.Run(() =>
                {
                    MessageBox.Show("historyLoader" + err.ToString());
                });

            }
            if (dataGridHistorico.Rows.Count < 1)
            {
                var indexInit = dataGridHistorico.Rows.Add();
                dataGridHistorico.Rows[indexInit].Cells[dataGridHistorico.Columns["ColumnNome"].Index].ReadOnly = true;
                dataGridHistorico.Rows[indexInit].Cells[dataGridHistorico.Columns["ColumnCPF"].Index].ReadOnly = true;
                dataGridHistorico.Rows[indexInit].Cells[dataGridHistorico.Columns["ColumnAcao"].Index].ReadOnly = true;
                dataGridHistorico.Rows[indexInit].Cells[dataGridHistorico.Columns["ColumnImprimir"].Index].ReadOnly = true;
                dataGridHistorico.Rows[indexInit].Cells[dataGridHistorico.Columns["ColumnPrestador"].Index].ReadOnly = true;
                dataGridHistorico.Rows[indexInit].Cells[dataGridHistorico.Columns["DataNascimento"].Index].ReadOnly = true;
                dataGridHistorico.Rows[indexInit].Cells[dataGridHistorico.Columns["ColumnImprime"].Index].ReadOnly = true;
                dataGridHistorico.Rows[indexInit].Cells[dataGridHistorico.Columns["ColumnHorario"].Index].ReadOnly = true;
            }
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
                lbl_msg.Text = "Registre a entrada pela Biometria";
                lblNome.Text = "";
                lblCPF.Text = "";
                lblDtNascimento.Text = "";
                pictureFotoPerfil.Image = null;
                Task.Run(() =>
                {
                    MessageBox.Show("FIRs carregadas com sucesso");
                });
            }
            catch (Exception erro)
            {
                Task.Run(() =>
                {
                    MessageBox.Show("LoadFirs" + erro.ToString());
                });

            }
        }
        public void ReLoadFirs()
        {
            try
            {
                m_IndexSearch.ClearDB();
                jsonFirs = null;
                var firs = clientHttp.GetAsync(urlApi + "biometria/dados").Result;

                if ((int)firs.StatusCode == 200)
                {
                    //m_NBioAPI = new NBioAPI();
                    //m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);

                    //m_IndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
                    //m_IndexSearch.InitEngine();

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
                lbl_msg.Text = "Registre a entrada pela Biometria";
                lblNome.Text = "";
                lblCPF.Text = "";
                lblDtNascimento.Text = "";
                pictureFotoPerfil.Image = null;
                Task.Run(() =>
                {
                    MessageBox.Show("FIRs carregadas com sucesso");
                });
            }
            catch (Exception erro)
            {
                Task.Run(() =>
                {
                    MessageBox.Show("ReLoadFirs" + erro.ToString());
                });

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

        private void FIRCheck()
        {
            try
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

                                    { "host_name_maquina_registro", System.Environment.MachineName },
                                    { "nr_cpf", payload.Data.Split(char.Parse(" "))[1] },
                                    { "nr_senha", payload.Data.Split(char.Parse(" "))[0] },
                                    { "registroPrestador", checkBoxPrestador.Checked ? "on":"off" }

                                };

                                var response = clientHttp.PostAsync(urlApi + "registraAcesso", new FormUrlEncodedContent(values)).Result;

                                if ((int)response.StatusCode == 200)
                                {
                                    dynamic contentResponse = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

                                    lbl_msg.Text = contentResponse["mensagem"].mensagem.ToString();

                                    lblNome.Text = contentResponse["usuario"].nm_profissional.ToString();
                                    lblCPF.Text = contentResponse["usuario"].nr_cpf.ToString();
                                    lblDtNascimento.Text = contentResponse["usuario"].dt_nacimento.ToString("dd/MM/yyyy");
                                    var teste = contentResponse["img"].ToString();
                                    pictureFotoPerfil.Image = contentResponse["img"].ToString() == "" ? Properties.Resources.noImage : LoadBase64(contentResponse["img"].ToString());
                                    pictureFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                                    DateTime zeroTime = new DateTime(1, 1, 1);
                                    TimeSpan span = DateTime.Now.Subtract(DateTime.Parse(contentResponse["usuario"].dt_nacimento.ToString("dd/MM/yyyy")));

                                    int years = (zeroTime + span).Year - 1;


                                    DataGridViewRow dataGridViewRowModeloNew = (DataGridViewRow)dataGridHistorico.Rows[0].Clone();

                                    dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnNome"].Index].Value = lblNome.Text;
                                    dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnCPF"].Index].Value = lblCPF.Text;
                                    dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnAcao"].Index].Value = contentResponse["mensagem"].acao.ToString();
                                    dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["DataNascimento"].Index].Value = years.ToString();
                                    dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnHorario"].Index].Value = DateTime.Now.ToString("HH:mm:ss");

                                    if (contentResponse["mensagem"].imprime.ToString() == "True")
                                    {
                                        dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnImprimir"].Index].ReadOnly = false;
                                        dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnImprime"].Index].Value = true;
                                    }
                                    else
                                    {
                                        dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnImprime"].Index].Value = false;
                                        dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnImprimir"].Index].ReadOnly = true;
                                    }

                                    if (contentResponse["mensagem"].prestador.ToString() == "True")
                                    {
                                        if (checkBoxPrestador.Checked)
                                        {
                                            dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnPrestador"].Index].Value = false;
                                        }
                                        else
                                        {
                                            dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnPrestador"].Index].Value = true;
                                        }
                                    }
                                    else
                                    {
                                        dataGridViewRowModeloNew.Cells[dataGridHistorico.Columns["ColumnPrestador"].Index].Value = false;
                                    }

                                    dataGridHistorico.Rows.Insert(0, dataGridViewRowModeloNew);


                                    DataTable dT = GetDataTableFromDGV(dataGridHistorico);
                                    DataSet dS = new DataSet();
                                    dS.Tables.Add(dT);

                                    using (var stream = File.OpenWrite(Path.Combine(path, "HistoricoTHMAcesso.xml")))
                                    {
                                        dS.WriteXml(stream);
                                    }

                                    checkBoxPrestador.Checked = false;

                                    TimerVerifyFinger.Interval = 4000;
                                    TimerVerifyFinger.Start();
                                }
                                else
                                {
                                    MessageBox.Show("Codigo de erro do servidor: " + response.StatusCode.ToString());
                                    TimerVerifyFinger.Interval = 4000;
                                    TimerVerifyFinger.Start();

                                }
                            }
                            break;
                        }

                    }
                }
            }
            catch (Exception erro)
            {
                Task.Run(() =>
                {
                    
                    MessageBox.Show("FirCheck" + erro.ToString());
                });
            }
        }

        private void TimerVerifyFinger_Tick(object sender, EventArgs e)
        {
            lbl_msg_TextChanged();
            TimerVerifyFinger.Stop();
            try
            {

                bool dedoNoSensor;
                m_NBioAPI.CheckFinger(out dedoNoSensor);

                if (dedoNoSensor)
                {
                    FIRCheck();
                    TimerVerifyFinger.Interval = 4000;
                    TimerVerifyFinger.Start();


                }
                else
                {
                    resetText = true;
                    TimerVerifyFinger.Interval = 300;
                    TimerVerifyFinger.Start();
                }
            }
            catch (Exception erro)
            {
                lbl_msg.Text = "Erro no sistema, procure a equipe de TI!";
                Task.Run(() =>
                {
                    MessageBox.Show("TimerVerifyFinger_Tick" + erro.ToString());
                });
            }
        }





        public void dataGridHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == dataGridHistorico.Columns["ColumnImprimir"].Index && e.RowIndex >= 0 && dataGridHistorico.Rows[e.RowIndex].Cells[dataGridHistorico.Columns["ColumnImprime"].Index].Value.ToString() == "True")
            {

                PrintDocument p = new PrintDocument();
                p.PrintPage += delegate (object senderPrint, PrintPageEventArgs ePrint)
                {
                    if (dataGridHistorico.Rows[e.RowIndex].Cells[dataGridHistorico.Columns["ColumnPrestador"].Index].Value.ToString() == "True")
                    {
                        ePrint.Graphics.DrawString("Prestador", new Font("Inter", 36), new SolidBrush(Color.Black), new Point(165, 0));
                    }
                    else
                    {
                        ePrint.Graphics.DrawString("Visitante", new Font("Inter", 36), new SolidBrush(Color.Black), new Point(165, 0));
                    }
                    ePrint.Graphics.DrawString("NOME: " + dataGridHistorico.Rows[e.RowIndex].Cells[dataGridHistorico.Columns["ColumnNome"].Index].Value.ToString(), new Font("Inter", 12), new SolidBrush(Color.Black), new RectangleF(155, 48, 250, 40));
                    ePrint.Graphics.DrawString("CPF: " + dataGridHistorico.Rows[e.RowIndex].Cells[dataGridHistorico.Columns["ColumnCPF"].Index].Value.ToString(), new Font("Inter", 12), new SolidBrush(Color.Black), new Point(155, 83));
                    ePrint.Graphics.DrawString("IDADE: " + dataGridHistorico.Rows[e.RowIndex].Cells[dataGridHistorico.Columns["DataNascimento"].Index].Value.ToString(), new Font("Inter", 12), new SolidBrush(Color.Black), new Point(155, 98));
                    ePrint.Graphics.DrawString("ENTRADA: " + DateTime.Now.ToString("dd/MM/yy AS HH:mm"), new Font("Inter", 12), new SolidBrush(Color.Black), new Point(155, 115));

                    ePrint.Graphics.DrawImage(Properties.Resources.LOGO_1, 0, 30, 150, 70);

                };
                try
                {
                    p.Print();
                }
                catch (Exception erro)
                {
                    throw new Exception("Erro cell click", erro);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ReLoadFirs();

            }
            catch (Exception erro)
            {
                Task.Run(() =>
                {
                    MessageBox.Show("Btn_atualizar"+erro.ToString());
                });
            }
        }

    }

}





