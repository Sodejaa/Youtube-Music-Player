using System;
using System.Text.RegularExpressions;
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
            string videoIdOrPlaylistId = GetYouTubeVideoOrPlaylistId(txtLink.Text);

            if (videoIdOrPlaylistId != null)
            {
                string embedUrl = IsPlaylist(videoIdOrPlaylistId)
                    ? $"https://www.youtube.com/embed/videoseries?list={videoIdOrPlaylistId}&listType=playlist"
                    : $"https://www.youtube.com/embed/{videoIdOrPlaylistId}";

                // Generates an HTML string and sets it as the DocumentText property of a WebBrowser control (WebVideo).
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "</head><body>";
                html += $"<object type='text/html' data='{embedUrl}' width='600' height='300'></object>";
                html += "</body></html>";

                this.WebVideo.DocumentText = html;
            }
            else
            {
                MessageBox.Show("Invalid YouTube link.");
            }
        }

        private string GetYouTubeVideoOrPlaylistId(string url)
        {
            // Regex captures different variations of YouTube video and playlist URLs.
            var regex = new Regex(@"(?:youtube\.com\/(?:[^\/\n\s]+\/\S+\/|(?:v|e(?:mbed)?)\/|\S*?[?&]v=)|youtu\.be\/|youtube\.com\/playlist\?list=)([a-zA-Z0-9_-]{11})", RegexOptions.IgnoreCase);

            // This line uses the regular expression (regex) to match against the provided url.
            var match = regex.Match(url);

            // Checks if the match was successful by accessing the Success property of the Match object.
            return match.Success ? match.Groups[1].Value : null;
        }

        private bool IsPlaylist(string id)
        {
            // Check if the provided ID corresponds to a playlist (length is usually 34 characters for playlists).
            return id.Length >= 32 && id.Length <= 36;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txtLink_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
