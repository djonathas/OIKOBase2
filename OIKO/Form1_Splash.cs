using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oiko.controllers;

namespace Oiko
{
    public partial class Form1_Splash : Form
    {
        public Form1_Splash()
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
                if (UsuarioController.existeUsuario())
                {
                    Form2_Login l = new Form2_Login();
                    l.Show();
                }
                else
                {
                    Form10_PrimeAcesso p = new Form10_PrimeAcesso();
                    p.Show();
                }
                this.Hide();
            }
        }
    }
}
