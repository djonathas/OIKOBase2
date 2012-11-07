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
    public partial class Form2_Login : Form
    {
        public Form2_Login()
        {
            InitializeComponent();
        }

        private void button_Login_Entrar_Click(object sender, EventArgs e)
        {
            Form3_Principal p = new Form3_Principal();
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
