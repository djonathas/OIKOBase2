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
    public partial class Form2_Login : Form
    {
        public Form2_Login()
        {
            InitializeComponent();
            textBox_Login_Usuario.Select();
        }

        private void button_Login_Entrar_Click(object sender, EventArgs e)
        {
            System.Drawing.Color Red = System.Drawing.ColorTranslator.FromHtml("#ED3237");

            if (textBox_Login_Usuario.Text == String.Empty || textBox_Login_Senha.Text == String.Empty)
            {
                MessageBox.Show("Um dos campos obrigatório foi deixado em "+"\nbranco ou está em um formato inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                limparTexto();
            }
            else    
            {
                Usuario usuario = UsuarioController.get();
                if (usuario.login == textBox_Login_Usuario.Text) 
                {
                    if (usuario.senha == textBox_Login_Senha.Text)
                    {
                        Form3_Principal p = new Form3_Principal();
                        p.Show();
                        this.Hide();
                    }
                    else
                    {
                        textBox_Login_Senha.BackColor = Red;
                        MessageBox.Show("A senha está incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        limparTexto();
                    }
                }
                else
                {
                    textBox_Login_Usuario.BackColor = Red;
                    MessageBox.Show("O login está incorreto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    limparTexto();
                }

            }
        }

        private void button_Login_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resu == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

        private void button_Teste_Click(object sender, EventArgs e)
        {
            Form10_PrimeAcesso n = new Form10_PrimeAcesso();
            n.Show();
        }

        private void limparTexto()
        {
            textBox_Login_Usuario.ResetText(); 
            textBox_Login_Usuario.Select();
            textBox_Login_Senha.ResetText();
            textBox_Login_Usuario.BackColor = Color.White;
            textBox_Login_Senha.BackColor = Color.White;
        }

        private void textBox_Login_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button_Login_Entrar_Click(sender, e);
            }
        }
    }
}
