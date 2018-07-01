namespace SIS0589A_Daltonismo
{
    partial class AboutWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
			this.labelAboutProject = new System.Windows.Forms.Label();
			this.GitHubRepos = new System.Windows.Forms.LinkLabel();
			this.GitHubImage = new System.Windows.Forms.PictureBox();
			this.labelUcs = new System.Windows.Forms.Label();
			this.pictureBoxUcsLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.GitHubImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUcsLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// labelAboutProject
			// 
			this.labelAboutProject.AutoSize = true;
			this.labelAboutProject.Location = new System.Drawing.Point(27, 76);
			this.labelAboutProject.Name = "labelAboutProject";
			this.labelAboutProject.Size = new System.Drawing.Size(240, 128);
			this.labelAboutProject.TabIndex = 0;
			this.labelAboutProject.Text = "SIS0589A_Projeto Cenoura: Daltônicos\r\n\r\nDesnvolvido por:\r\n\r\nDaniel Abreu;\r\nFábio " +
    "Orlandi;\r\nGabriel Mânica;\r\nRonald Gamba";
			// 
			// GitHubRepos
			// 
			this.GitHubRepos.AutoSize = true;
			this.GitHubRepos.Location = new System.Drawing.Point(331, 134);
			this.GitHubRepos.Name = "GitHubRepos";
			this.GitHubRepos.Size = new System.Drawing.Size(227, 16);
			this.GitHubRepos.TabIndex = 1;
			this.GitHubRepos.TabStop = true;
			this.GitHubRepos.Text = "Link to our public repository in GitHub";
			this.GitHubRepos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubRepos_LinkClicked);
			// 
			// GitHubImage
			// 
			this.GitHubImage.Image = ((System.Drawing.Image)(resources.GetObject("GitHubImage.Image")));
			this.GitHubImage.ImageLocation = "";
			this.GitHubImage.InitialImage = null;
			this.GitHubImage.Location = new System.Drawing.Point(291, 125);
			this.GitHubImage.Name = "GitHubImage";
			this.GitHubImage.Size = new System.Drawing.Size(34, 34);
			this.GitHubImage.TabIndex = 2;
			this.GitHubImage.TabStop = false;
			this.GitHubImage.WaitOnLoad = true;
			// 
			// labelUcs
			// 
			this.labelUcs.AutoSize = true;
			this.labelUcs.Location = new System.Drawing.Point(502, 211);
			this.labelUcs.Name = "labelUcs";
			this.labelUcs.Size = new System.Drawing.Size(70, 16);
			this.labelUcs.TabIndex = 3;
			this.labelUcs.Text = "UCS, 2018";
			// 
			// pictureBoxUcsLogo
			// 
			this.pictureBoxUcsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUcsLogo.Image")));
			this.pictureBoxUcsLogo.Location = new System.Drawing.Point(243, 12);
			this.pictureBoxUcsLogo.Name = "pictureBoxUcsLogo";
			this.pictureBoxUcsLogo.Size = new System.Drawing.Size(92, 61);
			this.pictureBoxUcsLogo.TabIndex = 4;
			this.pictureBoxUcsLogo.TabStop = false;
			// 
			// AboutWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 236);
			this.Controls.Add(this.pictureBoxUcsLogo);
			this.Controls.Add(this.labelUcs);
			this.Controls.Add(this.GitHubImage);
			this.Controls.Add(this.GitHubRepos);
			this.Controls.Add(this.labelAboutProject);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(600, 275);
			this.MinimumSize = new System.Drawing.Size(600, 275);
			this.Name = "AboutWindow";
			this.Text = "Sobre: Projeto Cenoura";
			((System.ComponentModel.ISupportInitialize)(this.GitHubImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUcsLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAboutProject;
		private System.Windows.Forms.LinkLabel GitHubRepos;
		private System.Windows.Forms.PictureBox GitHubImage;
		private System.Windows.Forms.Label labelUcs;
		private System.Windows.Forms.PictureBox pictureBoxUcsLogo;
	}
}