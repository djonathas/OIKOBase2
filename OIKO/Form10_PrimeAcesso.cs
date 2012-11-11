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
    public partial class Form10_PrimeAcesso : Form
    {
        public Form10_PrimeAcesso()
        {
            InitializeComponent();
            textBox_1Acesso_NomeUsuario.Select();
        }

        private void button_1Acesso_Cadastrar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            
            try
            {
                usuario.nome = textBox_1Acesso_NomeUsuario.Text;
                usuario.email = textBox_1Acesso_Email.Text;
                usuario.login = textBox_1Acesso_Login.Text;
                usuario.senha = textBox_1Acesso_Senha.Text;

                UsuarioController.add(usuario);
                MessageBox.Show("Dados Cadastrados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                Form3_Principal p = new Form3_Principal();
                p.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um dos campos obrigatório foi deixado em branco ou está em um formato inválido!" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button_1Acesso_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resu == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

        private void textBox_1Acesso_Confir_KeyPress(object sender, KeyPressEventArgs e)
        {
            button_1Acesso_Cadastrar_Click(sender, e);
        }
    }
}
