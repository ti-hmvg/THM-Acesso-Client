using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using NITGEN.SDK.NBioBSP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THM_Acesso
{
    public partial class Main : Form
    {
        string urlApi, connStr;
        NBioAPI m_NBioAPI;
        NBioAPI.IndexSearch m_IndexSearch;   
        NBioAPI.IndexSearch.FP_INFO[] fpInfo;
        NBioAPI.Type.HFIR HFirCapturado;
        MySqlConnection connection;
        DataTable dt;
        private static HttpClient client;
        private void TimerVerifyFinger_Tick(object sender, EventArgs e)
        {
            /*try
            {
                TimerVerifyFinger.Interval = 300;
                TimerVerifyFinger.Stop();
                bool dedoNoSensor;
                m_NBioAPI.CheckFinger(out dedoNoSensor);

                if (dedoNoSensor)
                {
                    NBioAPI.IndexSearch.FP_INFO fpInfo1;
                    NBioAPI.IndexSearch.CALLBACK_INFO_0 CallbackInfo = new NBioAPI.IndexSearch.CALLBACK_INFO_0();
                    bool resultMatch;
                    NBioAPI.Type.FIR_PAYLOAD payload = new NBioAPI.Type.FIR_PAYLOAD();
                    client = new HttpClient();

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

                        foreach (DataRow linha in dt.Rows)
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

                                    var content = new FormUrlEncodedContent(values);

                                    var response = client.PostAsync(urlApi + "biometria/frequencia", content).Result;

                                    var contentResponse = response.Content.ReadAsStringAsync().Result;
                                    
                                }
                            }
                        }
                    }
                }
                else
                {
                    TimerVerifyFinger.Start();
                }
            }
            catch (Exception err)
            {
                lbl_msg.Text = "Erro no sistema, procure a equipe de TI!";
                MessageBox.Show(err.ToString());
            }*/
        }

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

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        public Main()
        {
            InitializeComponent();
            
            /*urlApi = ConfigurationManager.AppSettings.Get("UrlApi");

            connStr = ConfigurationManager.AppSettings.Get("ConnString") + "user=remoto;database=mestre;port=3306;password=aew!2121";
            connection = new MySqlConnection(connStr);

            m_NBioAPI = new NBioAPI();
            m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);

            m_IndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
            m_IndexSearch.InitEngine();

            MySqlDataReader firsDB;
            DataTable dt;
            try
            {
                connection.Open();
                var command = new MySqlCommand("SELECT fir_digital,cd_profissional FROM profissional where fir_digital IS NOT NULL", connection);
                firsDB = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(firsDB);

                foreach (DataRow row in dt.Rows)
                {
                    m_IndexSearch.AddFIR(new NBioAPI.Type.FIR_TEXTENCODE
                    {
                        IsWideChar = true,
                        TextFIR = row["fir_digital"].ToString()
                    }, uint.Parse(row["cd_profissional"].ToString()), out fpInfo);
                }

                connection.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                MessageBox.Show(e.Message);
                connection.Close();
                throw e;
            }*/



        }

    }
}
