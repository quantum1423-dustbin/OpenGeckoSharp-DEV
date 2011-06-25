using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Windows.Forms;

namespace Skybound.Gecko
{
    public partial class DLHandler : Form
    {
        public DLHandler()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void DLHandler_Load(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = System.IO.Path.GetFileName(GeckoWebBrowser.durl);
            saveFileDialog1.ShowDialog();
            textBox1.Text = GeckoWebBrowser.durl;
            textBox2.Text = saveFileDialog1.FileName;
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri(textBox1.Text), textBox2.Text);
        }

        void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Close();
        }

        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = Convert.ToInt32(e.TotalBytesToReceive);
            progressBar1.Value = Convert.ToInt32(e.BytesReceived);
            label5.Text = e.BytesReceived.ToString();
            label6.Text = e.TotalBytesToReceive.ToString();
        }
    }
}
