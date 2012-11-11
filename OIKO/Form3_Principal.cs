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
    public partial class Form3_Principal : Form
    {

        public Form3_Principal()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_Receita_Click(object sender, EventArgs e)
        {
            Form5_Lancamentos novo = new Form5_Lancamentos("receita");
            novo.TopLevel = false;
            novo.FormBorderStyle = FormBorderStyle.None;
            novo.WindowState = FormWindowState.Maximized;
            panel_Central.Controls.Clear();
            panel_Central.Controls.Add(novo);
            novo.Show();
        }

        private void ToolStripMenuItem_Despesa_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Categorias_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_FormasPaga_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Sair_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_ContaPagar_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_ContaRece_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Calculadora_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Word_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Excel_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Explorer_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Sobre_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_LancarRece_Click(object sender, EventArgs e)
        {
            Form5_Lancamentos novo = new Form5_Lancamentos("receita");
            novo.TopLevel = false;
            novo.FormBorderStyle = FormBorderStyle.None;
            novo.WindowState = FormWindowState.Maximized;
            panel_Central.Controls.Clear();
            panel_Central.Controls.Add(novo);
            novo.Show();
        }

        private void toolStripButtontoolStripButton_LancarDespe_Click(object sender, EventArgs e)
        {
            Form5_Lancamentos novo = new Form5_Lancamentos("despesa");
            novo.TopLevel = false;
            novo.FormBorderStyle = FormBorderStyle.None;
            novo.WindowState = FormWindowState.Maximized;
            panel_Central.Controls.Clear();
            panel_Central.Controls.Add(novo);
            novo.Show();
        }

        private void toolStripButton_ContasReceber_Click(object sender, EventArgs e)
        {
            Form5_Lancamentos novo = new Form5_Lancamentos();
            novo.TopLevel = false;
            novo.FormBorderStyle = FormBorderStyle.None;
            novo.WindowState = FormWindowState.Maximized;
            panel_Central.Controls.Clear();
            panel_Central.Controls.Add(novo);
            novo.Show();
        }

        private void toolStripButton_ContasPagar_Click(object sender, EventArgs e)
        {
            Form5_Lancamentos novo = new Form5_Lancamentos();
            novo.TopLevel = false;
            novo.FormBorderStyle = FormBorderStyle.None;
            novo.WindowState = FormWindowState.Maximized;
            panel_Central.Controls.Clear();
            panel_Central.Controls.Add(novo);
            novo.Show();
        }

        private void toolStripButton_Relatorios_Click(object sender, EventArgs e)
        {
            Form6_Relatorio novo = new Form6_Relatorio();
            novo.TopLevel = false;
            novo.FormBorderStyle = FormBorderStyle.None;
            novo.WindowState = FormWindowState.Maximized;
            panel_Central.Controls.Clear();
            panel_Central.Controls.Add(novo);
            novo.Show();
        }

        private void toolStripButton_Preferencia_Click(object sender, EventArgs e)
        {
            Form8_Preferencias novo = new Form8_Preferencias();
            novo.TopLevel = false;
            novo.FormBorderStyle = FormBorderStyle.None;
            novo.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            panel_Central.Controls.Clear();
            panel_Central.Controls.Add(novo);
            novo.Show();
        }

        private void Form3_Principal_Load(object sender, EventArgs e)
        {
            Form4_VisaoGeral novo = new Form4_VisaoGeral();
            novo.TopLevel = false;
            novo.FormBorderStyle = FormBorderStyle.None;
            novo.WindowState = FormWindowState.Maximized;
            panel_Central.Controls.Clear();
            panel_Central.Controls.Add(novo);
            novo.Show();
        }

        private void toolStripButton_Home_Click(object sender, EventArgs e)
        {
            Form4_VisaoGeral novo = new Form4_VisaoGeral();
            novo.TopLevel = false;
            novo.FormBorderStyle = FormBorderStyle.None;
            novo.WindowState = FormWindowState.Maximized;
            panel_Central.Controls.Clear();
            panel_Central.Controls.Add(novo);
            novo.Show();
        }
    }
}
