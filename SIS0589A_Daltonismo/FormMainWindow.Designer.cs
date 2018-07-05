namespace ColorblindProjecty
{
    partial class FormMainWindow
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainWindow));
			this.pictureBoxMainImage = new System.Windows.Forms.PictureBox();
			this.labelSelectedColor = new System.Windows.Forms.Label();
			this.labelHSV = new System.Windows.Forms.Label();
			this.labelHexadecimalValue = new System.Windows.Forms.Label();
			this.labelRGBValue = new System.Windows.Forms.Label();
			this.textBoxHSV = new System.Windows.Forms.TextBox();
			this.textBoxHexadecimalValue = new System.Windows.Forms.TextBox();
			this.textBoxRGBValue = new System.Windows.Forms.TextBox();
			this.buttonRelatedImages = new System.Windows.Forms.Button();
			this.buttonHelp = new System.Windows.Forms.Button();
			this.buttonAbout = new System.Windows.Forms.Button();
			this.timerMouseOnImage = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxMainImage
			// 
			this.pictureBoxMainImage.Location = new System.Drawing.Point(35, 50);
			this.pictureBoxMainImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBoxMainImage.Name = "pictureBoxMainImage";
			this.pictureBoxMainImage.Size = new System.Drawing.Size(197, 95);
			this.pictureBoxMainImage.TabIndex = 0;
			this.pictureBoxMainImage.TabStop = false;
			this.pictureBoxMainImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMainImage_MouseMove);
			// 
			// labelSelectedColor
			// 
			this.labelSelectedColor.AutoSize = true;
			this.labelSelectedColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSelectedColor.Location = new System.Drawing.Point(32, 26);
			this.labelSelectedColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelSelectedColor.Name = "labelSelectedColor";
			this.labelSelectedColor.Size = new System.Drawing.Size(133, 18);
			this.labelSelectedColor.TabIndex = 1;
			this.labelSelectedColor.Text = "Cor Selecionada";
			// 
			// labelHSV
			// 
			this.labelHSV.AutoSize = true;
			this.labelHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHSV.Location = new System.Drawing.Point(406, 71);
			this.labelHSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelHSV.Name = "labelHSV";
			this.labelHSV.Size = new System.Drawing.Size(95, 18);
			this.labelHSV.TabIndex = 2;
			this.labelHSV.Text = "HSB / HSV ";
			// 
			// labelHexadecimalValue
			// 
			this.labelHexadecimalValue.AutoSize = true;
			this.labelHexadecimalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHexadecimalValue.Location = new System.Drawing.Point(255, 26);
			this.labelHexadecimalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelHexadecimalValue.Name = "labelHexadecimalValue";
			this.labelHexadecimalValue.Size = new System.Drawing.Size(104, 18);
			this.labelHexadecimalValue.TabIndex = 3;
			this.labelHexadecimalValue.Text = "Hexadecimal";
			// 
			// labelRGBValue
			// 
			this.labelRGBValue.AutoSize = true;
			this.labelRGBValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRGBValue.Location = new System.Drawing.Point(255, 99);
			this.labelRGBValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelRGBValue.Name = "labelRGBValue";
			this.labelRGBValue.Size = new System.Drawing.Size(44, 18);
			this.labelRGBValue.TabIndex = 4;
			this.labelRGBValue.Text = "RGB";
			// 
			// textBoxHSV
			// 
			this.textBoxHSV.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.textBoxHSV.Location = new System.Drawing.Point(409, 93);
			this.textBoxHSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxHSV.Name = "textBoxHSV";
			this.textBoxHSV.ReadOnly = true;
			this.textBoxHSV.Size = new System.Drawing.Size(132, 24);
			this.textBoxHSV.TabIndex = 5;
			// 
			// textBoxHexadecimalValue
			// 
			this.textBoxHexadecimalValue.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxHexadecimalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.textBoxHexadecimalValue.Location = new System.Drawing.Point(258, 51);
			this.textBoxHexadecimalValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxHexadecimalValue.Name = "textBoxHexadecimalValue";
			this.textBoxHexadecimalValue.ReadOnly = true;
			this.textBoxHexadecimalValue.Size = new System.Drawing.Size(132, 24);
			this.textBoxHexadecimalValue.TabIndex = 6;
			// 
			// textBoxRGBValue
			// 
			this.textBoxRGBValue.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxRGBValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.textBoxRGBValue.Location = new System.Drawing.Point(258, 121);
			this.textBoxRGBValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxRGBValue.Name = "textBoxRGBValue";
			this.textBoxRGBValue.ReadOnly = true;
			this.textBoxRGBValue.Size = new System.Drawing.Size(132, 24);
			this.textBoxRGBValue.TabIndex = 7;
			// 
			// buttonRelatedImages
			// 
			this.buttonRelatedImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.buttonRelatedImages.Location = new System.Drawing.Point(79, 168);
			this.buttonRelatedImages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonRelatedImages.Name = "buttonRelatedImages";
			this.buttonRelatedImages.Size = new System.Drawing.Size(117, 49);
			this.buttonRelatedImages.TabIndex = 8;
			this.buttonRelatedImages.Text = "Imagens Relacionadas";
			this.buttonRelatedImages.UseVisualStyleBackColor = true;
			this.buttonRelatedImages.Click += new System.EventHandler(this.ButtonRelatedImages_Click);
			// 
			// buttonHelp
			// 
			this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.buttonHelp.Location = new System.Drawing.Point(232, 168);
			this.buttonHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new System.Drawing.Size(117, 49);
			this.buttonHelp.TabIndex = 9;
			this.buttonHelp.Text = "Ajuda";
			this.buttonHelp.UseVisualStyleBackColor = true;
			this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
			// 
			// buttonAbout
			// 
			this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.buttonAbout.Location = new System.Drawing.Point(384, 168);
			this.buttonAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonAbout.Name = "buttonAbout";
			this.buttonAbout.Size = new System.Drawing.Size(117, 49);
			this.buttonAbout.TabIndex = 10;
			this.buttonAbout.Text = "Sobre";
			this.buttonAbout.UseVisualStyleBackColor = true;
			this.buttonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
			// 
			// timerMouseOnImage
			// 
			this.timerMouseOnImage.Enabled = true;
			this.timerMouseOnImage.Interval = 1;
			this.timerMouseOnImage.Tick += new System.EventHandler(this.TimerMouseOnImage_Tick);
			// 
			// FormMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(584, 236);
			this.Controls.Add(this.buttonAbout);
			this.Controls.Add(this.buttonHelp);
			this.Controls.Add(this.buttonRelatedImages);
			this.Controls.Add(this.textBoxRGBValue);
			this.Controls.Add(this.textBoxHexadecimalValue);
			this.Controls.Add(this.textBoxHSV);
			this.Controls.Add(this.labelRGBValue);
			this.Controls.Add(this.labelHexadecimalValue);
			this.Controls.Add(this.labelHSV);
			this.Controls.Add(this.labelSelectedColor);
			this.Controls.Add(this.pictureBoxMainImage);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(600, 275);
			this.MinimumSize = new System.Drawing.Size(600, 275);
			this.Name = "FormMainWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Informações da Cor";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMainWindow_EspecificKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainImage;
        private System.Windows.Forms.Label labelSelectedColor;
        private System.Windows.Forms.Label labelHSV;
        private System.Windows.Forms.Label labelHexadecimalValue;
        private System.Windows.Forms.Label labelRGBValue;
        private System.Windows.Forms.TextBox textBoxHSV;
        private System.Windows.Forms.TextBox textBoxHexadecimalValue;
        private System.Windows.Forms.TextBox textBoxRGBValue;
        private System.Windows.Forms.Button buttonRelatedImages;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Timer timerMouseOnImage;
    }
}

