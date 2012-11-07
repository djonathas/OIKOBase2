using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oiko
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer_Splash_Tick(object sender, EventArgs e)
        {
            if (progressBar_Splash.Value < 100)
            {
                progressBar_Splash.Value = progressBar_Splash.Value + 2;
            }
            else
            {
                timer_Splash.Enabled = false;
                Principal nf = new Principal();
                nf.Show();
                this.Hide();
            }
        }
    }
}
