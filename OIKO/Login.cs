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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Login_Entrar_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void button_Login_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resu == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
                return; //verificar esta linha
        }
    }
}
