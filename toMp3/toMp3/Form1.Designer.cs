
namespace toMp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.btnVideo = new MaterialSkin.Controls.MaterialButton();
            this.btnDownload = new MaterialSkin.Controls.MaterialButton();
            this.txtURL = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnVideo);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 522);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = global::toMp3.Properties.Resources.baseline_logout_black_24dp;
            this.btnSearch.Location = new System.Drawing.Point(893, 206);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVideo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVideo.Depth = 0;
            this.btnVideo.HighEmphasis = true;
            this.btnVideo.Icon = null;
            this.btnVideo.Location = new System.Drawing.Point(655, 352);
            this.btnVideo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVideo.MinimumSize = new System.Drawing.Size(158, 36);
            this.btnVideo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(158, 36);
            this.btnVideo.TabIndex = 2;
            this.btnVideo.Text = "Video";
            this.btnVideo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVideo.UseAccentColor = false;
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDownload.Depth = 0;
            this.btnDownload.HighEmphasis = true;
            this.btnDownload.Icon = null;
            this.btnDownload.Location = new System.Drawing.Point(382, 352);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownload.MinimumSize = new System.Drawing.Size(158, 36);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(158, 36);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Mp3";
            this.btnDownload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDownload.UseAccentColor = false;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtURL
            // 
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.Depth = 0;
            this.txtURL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtURL.LeadingIcon = null;
            this.txtURL.Location = new System.Drawing.Point(283, 206);
            this.txtURL.MaximumSize = new System.Drawing.Size(603, 40);
            this.txtURL.MaxLength = 50;
            this.txtURL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtURL.Multiline = false;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(603, 40);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "";
            this.txtURL.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(268, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Youtube Downloader";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 522);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "toMp3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtURL;
        private MaterialSkin.Controls.MaterialButton btnVideo;
        private MaterialSkin.Controls.MaterialButton btnDownload;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private System.Windows.Forms.Label label1;
    }
}

