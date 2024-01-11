using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubePlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string videoId = GetYouTubeVideoId(txtLink.Text);

            if (videoId != null)
            {
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "</head><body>";
                html += $"<iframe id='video' src='https://www.youtube.com/embed/{videoId}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
                html += "</body></html>";

                this.WebVideo.DocumentText = html;
            }
            else
            {
                MessageBox.Show("Invalid YouTube link.");
            }
        }

        private string GetYouTubeVideoId(string url)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"(?:youtube\.com\/(?:[^\/\n\s]+\/\S+\/|(?:v|e(?:mbed)?)\/|\S*?[?&]v=)|youtu\.be\/)([a-zA-Z0-9_-]{11})", RegexOptions.IgnoreCase);
            var match = regex.Match(url);

            return match.Success ? match.Groups[1].Value : null;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txtLink_TextChanged(object sender, EventArgs e)
        {

        }
    }
}