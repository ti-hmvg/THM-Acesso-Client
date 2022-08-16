using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace THM_Acesso
{
    public partial class Cadastro : Form
    {
        private static HttpClient client;
        FilterInfoCollection videoDevices;
        public Cadastro()
        {
            /*var values = new Dictionary<string, string>
            {
                { "nr_cpf", },
                { "nr_senha",  }
            };

            var content = new FormUrlEncodedContent(values);*/
            InitializeComponent();
            
            mediaCapture = new Windows.Media.Capture.MediaCapture();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        

        private void btnCadastraImg_Click(object sender, EventArgs e)
        {
            
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
            //videoSource.SignalToStop();
        }

        private void btnCadastraDigital_Click(object sender, EventArgs e)
        {

        }
        

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            Bitmap bitmap = eventArgs.Frame;
            // process the frame
            imgPerfil.Image = (Bitmap)eventArgs.Frame.Clone();
            bitmap.Dispose();
            bitmap = null;
        }
    }
}
