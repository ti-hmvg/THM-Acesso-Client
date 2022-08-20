using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using NITGEN.SDK.NBioBSP;
using Isopoh.Cryptography.Argon2;
using System.Configuration;

namespace THM_Acesso
{
    public partial class Cadastro : Form
    {
        string urlApi;
        private static HttpClient client;
        FilterInfoCollection videoDevices;
        byte[] imgBlob;
        string apiKey;
        Dictionary<string, string> postContent;
        NBioAPI.Type.FIR_TEXTENCODE processedFIR;
        HttpClient clientHttp;
        private byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            ms.Position = 0;
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        
        public Cadastro()
        {
            urlApi = ConfigurationManager.AppSettings.Get("UrlApi");
            InitializeComponent();
        }

        

        private void btnCadastraImg_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastraDigital_Click(object sender, EventArgs e)
        {
            try
            {
                NBioAPI m_NBioAPI = new NBioAPI();
                NBioAPI.Type.HFIR hCapturedFIR;


                var key = new byte[32];
                var salt = new byte[32];
                var generator = System.Security.Cryptography.RandomNumberGenerator.Create();
                generator.GetBytes(key);
                generator.GetBytes(salt);

                apiKey = Convert.ToBase64String(key);

                m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                m_NBioAPI.Enroll(out hCapturedFIR, new NBioAPI.Type.FIR_PAYLOAD
                {
                    Data = string.Join(" ", new string[] { apiKey, txbCPF.Text })
                });
                m_NBioAPI.GetTextFIRFromHandle(hCapturedFIR, out processedFIR, true);
                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);

                btnCadastro.Visible = true;
            }
            catch (Exception)
            {
                btnCadastro.Visible = false;
                MessageBox.Show("Algum erro ocorreu durante o processo de Cadastro da Digital. Entre em contato com a equipe de TI.");
                throw;
            }
        }
        private void btnSelecionaImagem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var img = new Bitmap(openFileDialog1.FileName);
                    imgBlob = imageToByteArray(img);
                    imgPerfil.Image = byteArrayToImage(imgBlob);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Imagem inválida!");
                throw;
            }
        }

        private async void btnCadastro_Click(object sender, EventArgs e)
        {
            clientHttp = new HttpClient();

            postContent.Add("fir_digital", processedFIR.TextFIR);
            postContent.Add("api_key", Argon2.Hash(apiKey));
            postContent.Add("cpf", txbCPF.Text);
            postContent.Add("nome", txbNome.Text );
            postContent.Add("email", txbEmail.Text ); 
            postContent.Add("telefone", txbTelefone.Text );
            postContent.Add("hash_senha", txbSenha.Visible ? Argon2.Hash(txbSenha.Text):Argon2.Hash("HMVG@123"));
            postContent.Add("dt_nascimento",dtNascimento.Value.Date.ToString("yyyy-MM-dd"));
            postContent.Add("imagem", imgBlob.ToString());
            postContent.Add("permissoes_cd_permissao", "3");

            var content = new FormUrlEncodedContent(postContent);

            var response = await clientHttp.PostAsync(urlApi + "cadastraUsuario", content);
        }

        private void checkDigital_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkDigital.Checked)
            {
                txbSenha.Visible = false;
                lblSenha.Visible = false;
            }else{
                txbSenha.Visible = true;
                lblSenha.Visible = true;
            }
            
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            if (txbSenha.TextLength > 0){
                btnCadastro.Visible = true;
            }else{
                btnCadastro.Visible = false;
            }
        }
    }
}
