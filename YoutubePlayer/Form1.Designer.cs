namespace YoutubePlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLink = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.WebVideo = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txtLink
            // 
            this.txtLink.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLink.Location = new System.Drawing.Point(12, 21);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(532, 20);
            this.txtLink.TabIndex = 0;
            this.txtLink.Text = "Video Link";
            this.txtLink.TextChanged += new System.EventHandler(this.txtLink_TextChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(550, 19);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(12, 402);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(75, 23);
            this.BtnPlay.TabIndex = 2;
            this.BtnPlay.Text = "Play/Pause";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(93, 402);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 3;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(174, 402);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(255, 402);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 5;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // WebVideo
            // 
            this.WebVideo.Location = new System.Drawing.Point(12, 57);
            this.WebVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebVideo.Name = "WebVideo";
            this.WebVideo.Size = new System.Drawing.Size(612, 323);
            this.WebVideo.TabIndex = 6;
            this.WebVideo.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 442);
            this.Controls.Add(this.WebVideo);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtLink);
            this.Name = "Form1";
            this.Text = "YoutubePlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.WebBrowser WebVideo;
    }
}

