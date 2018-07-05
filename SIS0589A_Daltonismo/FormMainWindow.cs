using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace ColorblindProject
{
    public partial class FormMainWindow : Form
    {
        MouseMove mouseMove = new MouseMove();

        bool isKeyDown = true;

        public FormMainWindow()
        {
            InitializeComponent();

        }

        private void PictureBoxMainImage_MouseMove(object sender, MouseEventArgs e)
        {
                timerMouseOnImage.Start();
                timerMouseOnImage.Interval = 1;

        }

        private void TimerMouseOnImage_Tick(object sender, EventArgs e)
        {

            if (isKeyDown)
            {
                pictureBoxMainImage.BackColor = mouseMove.ChangePictureBoxBackground();

                textBoxRGBValue.Text = mouseMove.ChangeRGBValue();

                textBoxHexadecimalValue.Text = mouseMove.ChangeHexadecimalValue();

                textBoxHSV.Text = mouseMove.ChangeHSVValue();
            }
        }

        private void ButtonRelatedImages_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com.br/search?q=%23" + /*mouseMove.ChangeHexadecimalValue()*/textBoxHexadecimalValue.Text.Remove(0, 1) + "&source=lnms&tbm=isch");
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();

            helpWindow.Show();
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();

            aboutWindow.Show();
        }

        private void FormMainWindow_EspecificKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F6)
            {
                isKeyDown = false;
                timerMouseOnImage.Stop();
            }

            if (e.KeyCode == Keys.F5)
            {
                isKeyDown = true;
                timerMouseOnImage.Start();
                timerMouseOnImage.Interval = 1;
            }
        }
	}
}
