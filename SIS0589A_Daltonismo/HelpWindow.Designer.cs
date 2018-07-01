namespace SIS0589A_Daltonismo
{
    partial class HelpWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
			this.labelHowToUse = new System.Windows.Forms.Label();
			this.labelHelpDescription = new System.Windows.Forms.Label();
			this.labelDemonstrativeGif = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelHowToUse
			// 
			this.labelHowToUse.AutoSize = true;
			this.labelHowToUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHowToUse.Location = new System.Drawing.Point(22, 18);
			this.labelHowToUse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelHowToUse.Name = "labelHowToUse";
			this.labelHowToUse.Size = new System.Drawing.Size(114, 18);
			this.labelHowToUse.TabIndex = 0;
			this.labelHowToUse.Text = "Como utilizar:";
			// 
			// labelHelpDescription
			// 
			this.labelHelpDescription.AutoSize = true;
			this.labelHelpDescription.Location = new System.Drawing.Point(50, 43);
			this.labelHelpDescription.Name = "labelHelpDescription";
			this.labelHelpDescription.Size = new System.Drawing.Size(450, 80);
			this.labelHelpDescription.TabIndex = 1;
			this.labelHelpDescription.Text = "Aponte para a imagem desejada com o mouse, depois pressione o botão\r\nesquerdo par" +
    "a travar a seleção:\r\n\r\nF6 = Pause;\r\nF5 = Resume;\r\n";
			// 
			// labelDemonstrativeGif
			// 
			this.labelDemonstrativeGif.AutoSize = true;
			this.labelDemonstrativeGif.Location = new System.Drawing.Point(188, 150);
			this.labelDemonstrativeGif.Name = "labelDemonstrativeGif";
			this.labelDemonstrativeGif.Size = new System.Drawing.Size(169, 16);
			this.labelDemonstrativeGif.TabIndex = 2;
			this.labelDemonstrativeGif.Text = "\"Vídeo/GIF Demonstrativo\"";
			// 
			// HelpWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 236);
			this.Controls.Add(this.labelDemonstrativeGif);
			this.Controls.Add(this.labelHelpDescription);
			this.Controls.Add(this.labelHowToUse);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(600, 275);
			this.MinimumSize = new System.Drawing.Size(600, 275);
			this.Name = "HelpWindow";
			this.Text = "Ajuda";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHowToUse;
        private System.Windows.Forms.Label labelHelpDescription;
        private System.Windows.Forms.Label labelDemonstrativeGif;
    }
}