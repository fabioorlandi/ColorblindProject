using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorblindProject
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {		
            InitializeComponent();
        }

		private void GitHubRepos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/GitHFabio/ColorblindProject");
		}
	}
}
