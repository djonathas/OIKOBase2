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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            tabControl_A2_DetalhesLancamento.TabPages.Clear();
            tabControl_A2_DetalhesLancamento.TabPages.Add(tabPage_A2_DetalhesLancamento);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            OikoDataContext bd = new OikoDataContext();
            contaBindingSource.DataSource = bd.Conta;

            var consulta = from c in bd.Categoria
                           where c.tipo == "Receita"
                           select new { c.id, c.nome };
            categoriaBindingSource.DataSource = consulta;

            comboBox_A1_Categorias.SelectedItem = null;
            comboBox_A1_Conta.SelectedItem = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Data.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel_Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void ToolStripMenuItemCategorias_Click(object sender, EventArgs e)
        {
            Preferencias preferencias = new Preferencias("categoria");
            preferencias.Show();
        }

        private void toolStripButton_Preferencia_Click(object sender, EventArgs e)
        {
            Preferencias f = new Preferencias();
            //f.MdiParent = this;
            //f.WindowState = FormWindowState.Normal;
            //tabControl_Geral.Visible = false;
            f.Show();
        }

        private void tabControl_Geral_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl_Geral.SelectedIndex)
            {
                case 0: // aba visão geral
                    {
                        break;
                    }
                case 1: // aba lançamentos
                    {
                        AtualizarListaLancamentos();
                        comboBox_A2_Categoria.SelectedItem = null;
                        comboBox_A2_Conta.SelectedItem = null;
                        break;
                    }
                case 2: // aba relatorios
                    {
                        break;
                    }
                case 3: // aba planejamento
                    break;
            }
        }

        // -------- INICIO - Aba de Lançamentos --------

        private void dateTimePickerDataLancamento_Leave(object sender, EventArgs e)
        {
            if (dateTimePicker_A2_DataLanca.Value > DateTime.Now)
            {
                label_A2_Multa.Enabled = true;
                label_A2_JurosDia.Enabled = true;
                textBox_A2_JurosDia.Enabled = true;
                textBox_A2_Multa.Enabled = true;
            }
            else
            {
                label_A2_Multa.Enabled = false;
                label_A2_JurosDia.Enabled = false;
                textBox_A2_JurosDia.Enabled = false;
                textBox_A2_Multa.Enabled = false;
            }
        }

        private void buttonReceita_Click(object sender, EventArgs e)
        {
            tabControl_A2_NovoLancamento.SelectedTab.BackgroundImage = Oiko.Properties.Resources.green;
            button_A2_Despesa.Enabled = true;
            button_A2_Receita.Enabled = false;
            label_A2_FormaPaga.Enabled = false;
            comboBox_A2_FormaPaga.Enabled = false;

            OikoDataContext bd = new OikoDataContext();
            var consulta = from c in bd.Categoria
                           where c.tipo == "Receita"
                           select new { c.id, c.nome };
            categoriaBindingSource.DataSource = consulta;
        }

        private void buttonDespesa_Click(object sender, EventArgs e)
        {
            tabControl_A2_NovoLancamento.SelectedTab.BackgroundImage = Oiko.Properties.Resources.red;
            button_A2_Despesa.Enabled = false;
            button_A2_Receita.Enabled = true;
            label_A2_FormaPaga.Enabled = true;
            comboBox_A2_FormaPaga.Enabled = true;

            OikoDataContext bd = new OikoDataContext();
            var consulta = from c in bd.Categoria
                           where c.tipo == "Despesa"
                           select new { c.id, c.nome };
            categoriaBindingSource.DataSource = consulta;
            formaPagamentoBindingSource.DataSource = bd.FormaPagamento;
        }

        public void AtualizarListaLancamentos()
        {
            listView_A2_Lancamentos.Items.Clear();
            foreach (Lancamento lancamento in LancamentoController.all())
            {
                string status = statusToString(lancamento.status, lancamento.tipo);

                ListViewItem item = new ListViewItem(new string[] { 
                    lancamento.id.ToString(),
                    lancamento.dataLancamento.ToString("dd/MM/yyyy"),
                    lancamento.descricao,
                    lancamento.tipo,
                    CategoriaController.getCategoria(lancamento.idCategoria).nome,
                    lancamento.valor.ToString(),
                    status                  
                });
                listView_A2_Lancamentos.Items.Add(item);
            }
        }

        public String statusToString(bool status, string tipoLancamento)
        {
            if (status)
            {
                if (tipoLancamento == "Receita")
                {
                    return "Recebido";
                }
                return "Pago";
            }
            if (tipoLancamento == "Receita")
            {
                return "Não Recebido";
            }
            return "Não Pago";
        }

        private void buttonLancar_Click(object sender, EventArgs e)
        {
            Lancamento lancamento = new Lancamento();
            try
            {
                lancamento.dataLancamento = dateTimePicker_A2_DataLanca.Value;
                lancamento.valor = decimal.Parse(textBox_A2_Valor.Text);
                lancamento.descricao = textBox_A2_Descri.Text;
                lancamento.idCategoria = System.Convert.ToInt32(comboBox_A2_Categoria.SelectedValue);

                if (button_A2_Despesa.Enabled)
                {
                    lancamento.tipo = "Receita";
                }
                else
                {
                    lancamento.tipo = "Despesa";
                    lancamento.idFormaPagamento = System.Convert.ToInt32(comboBox_A2_FormaPaga.SelectedValue);
                }
                if (dateTimePicker_A2_DataLanca.Value > DateTime.Now)
                {
                    lancamento.multa = int.Parse(label_A2_MultaLanca2.Text);
                    lancamento.jurosPorDia = int.Parse(label_A2_JurosLanca2.Text);

                    if (lancamento.idConta != null)
                    {
                        lancamento.idConta = System.Convert.ToInt32(comboBox_A2_Conta.SelectedValue);
                    }
                }
                else
                {
                    lancamento.idConta = System.Convert.ToInt32(comboBox_A2_Conta.SelectedValue);
                }
                
                LancamentoController.add(lancamento);
                MessageBox.Show("Lançamento criado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListaLancamentos();
            }
            catch (Exception)
            {
                MessageBox.Show("Um campo obrigatório foi deixado em branco ou está em um formato incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }   
        }

        private void listView_A2_Lancamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idLancamento = int.Parse(listView_A2_Lancamentos.FocusedItem.SubItems[0].Text);
            Lancamento lancamento = LancamentoController.get(idLancamento);

            if (lancamento.tipo == "Receita")
            {
                tabPage_A2_DetalhesLancamento.BackgroundImage = Oiko.Properties.Resources.green;
            }
            else
            {
                tabPage_A2_DetalhesLancamento.BackgroundImage = Oiko.Properties.Resources.red;
            }
            label_A2_IdLanca2.Text = idLancamento.ToString();
            label_A2_DescricaoLanca2.Text = lancamento.descricao;
            label_A2_Status2.Text = statusToString(lancamento.status, lancamento.tipo);
            if (lancamento.status)
            {
                label_A2_Status2.ForeColor = Color.Green;
            }
            else
            {
                label_A2_Status2.ForeColor = Color.Red;
            }
            label_A2_MultaLanca2.Text = lancamento.multa.ToString();
            label_A2_JurosLanca2.Text = lancamento.jurosPorDia.ToString();
            label_A2_DataLancaVenc2.Text = lancamento.dataLancamento.ToString("dd/MM/yyyy");
            if (lancamento.dataRecebimentoPagamento != null)
            {
                label_A2_DataRecePaga2.Text = System.Convert.ToDateTime(lancamento.dataRecebimentoPagamento).ToString("dd/MM/yyyy");
            }
            else
            {
                label_A2_DataRecePaga2.Text = "";
            }
            if (lancamento.idConta != null)
            {
                label_A2_ContaUtilizada2.Text = ContaController.getConta((int)lancamento.idConta).nome;
            }
            else
            {
                label_A2_ContaUtilizada2.Text = "";
            }
            if (lancamento.dataLancamento > DateTime.Now)
            {
                button_A2_BaixaLancamento.Enabled = true;
                button_A2_ExcluirLancamento.Enabled = true;
            }
            else
            {
                button_A2_BaixaLancamento.Enabled = false;
                button_A2_ExcluirLancamento.Enabled = false;
            }
        }

        private void button_A2_EditarLancamento_Click(object sender, EventArgs e)
        {
            int idLancamento = int.Parse(label_A2_IdLanca2.Text);
            Lancamento lancamento = LancamentoController.get(idLancamento);

            if (lancamento.tipo == "Receita")
            {
                tabControl_A2_NovoLancamento.SelectedTab.BackgroundImage = Oiko.Properties.Resources.green;
                button_A2_Despesa.Enabled = false;
                button_A2_Receita.Enabled = false;
                label_A2_FormaPaga.Enabled = false;
                comboBox_A2_FormaPaga.Enabled = false;

                OikoDataContext bd = new OikoDataContext();
                var consulta = from c in bd.Categoria
                               where c.tipo == "Receita"
                               select new { c.id, c.nome };
                categoriaBindingSource.DataSource = consulta;
            }
            else
            {
                tabPage_A2_DetalhesLancamento.BackgroundImage = Oiko.Properties.Resources.red;
            }
        }

        private void button_A2_BaixaLancamento_Click(object sender, EventArgs e)
        {
            tabControl_A2_DetalhesLancamento.TabPages.Clear();
            tabControl_A2_DetalhesLancamento.TabPages.Add(tabPage_A2_BaixaLancamento);
        }

        private void comboBox_A2_Contas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_A2_DataLanca.Value > DateTime.Now)
            {
                DialogResult confirm = MessageBox.Show("Se você selecionar uma conta em um lançamento futuro irá habitar o débito automático para este lançamento.\nDeseja mesmo continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No)
                {
                    comboBox_A2_Conta.SelectedIndexChanged -= comboBox_A2_Contas_SelectedIndexChanged;
                    comboBox_A2_Conta.SelectedItem = null;
                    comboBox_A2_Conta.SelectedIndexChanged += comboBox_A2_Contas_SelectedIndexChanged;
                }
            }
        }

        private void ToolStripMenuItem_Sobre_Click(object sender, EventArgs e)
        {
            Sobre s = new Sobre();
            s.Show();
        }

        // -------- FIM - Aba de Lançamentos --------

    }
}
