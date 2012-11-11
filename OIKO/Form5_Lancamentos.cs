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
    public partial class Form5_Lancamentos : Form
    {

        public Form5_Lancamentos()
        {
            InitializeComponent();
            tabControl_A2_DetalhesLancamento.TabPages.Clear();
            tabControl_A2_DetalhesLancamento.TabPages.Add(tabPage_A2_DetalhesLancamento);
            textBox_A2_Descricao.Select();

            using (OikoDataContext bd = new OikoDataContext())
            {
                contaBindingSource.DataSource = bd.Conta;
                formaPagamentoBindingSource.DataSource = bd.FormaPagamento;
            }

            AtualizarListaLancamentos();
        }

        public Form5_Lancamentos(string tipo)
            : this()
        {
            if (tipo == "receita")
                habilitarReceita();
            else
                habilitarDespesa();
        }

        private void dateTimePickerDataLancamento_Leave(object sender, EventArgs e)
        {
            if (dateTimePicker_A2_DataLancamento.Value > DateTime.Now)
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

        #region Botões
        private void buttonReceita_Click(object sender, EventArgs e)
        {
            habilitarReceita();
        }

        private void buttonDespesa_Click(object sender, EventArgs e)
        {
            habilitarDespesa();
        }

        private void buttonLancar_Click(object sender, EventArgs e)
        {
            Lancamento lancamento = new Lancamento();
            
            try
            {
                lancamento.dataLancamento = dateTimePicker_A2_DataLancamento.Value;
                lancamento.valor = decimal.Parse(textBox_A2_Valor.Text);
                lancamento.descricao = textBox_A2_Descricao.Text;
                lancamento.idCategoria = Convert.ToInt32(comboBox_A2_Categoria.SelectedValue);

                if (button_A2_Despesa.Enabled)
                {
                    lancamento.tipo = "Receita";
                }
                else if (button_A2_Receita.Enabled)
                {
                    lancamento.tipo = "Despesa";
                    lancamento.idFormaPagamento = Convert.ToInt32(comboBox_A2_FormaPaga.SelectedValue);
                }
                if (dateTimePicker_A2_DataLancamento.Value > DateTime.Now)
                {
                    lancamento.multa = int.Parse(textBox_A2_Multa.Text);
                    lancamento.jurosPorDia = int.Parse(textBox_A2_JurosDia.Text);

                    if (comboBox_A2_Conta.SelectedItem != null)
                    {
                        lancamento.idConta = Convert.ToInt32(comboBox_A2_Conta.SelectedValue);
                    }
                }
                else
                {
                    lancamento.idConta = Convert.ToInt32(comboBox_A2_Conta.SelectedValue);
                    lancamento.status = true;
                }

                //if (idLancamento > -1)
                //{
                //    lancamento.id = idLancamento;
                //    LancamentoController.update(lancamento);
                //    button_A2_DesfazerEdicao.Visible = false;
                //    MessageBox.Show("Lançamento atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                    LancamentoController.add(lancamento);
                    MessageBox.Show("Lançamento criado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                AtualizarListaLancamentos();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um dos campos obrigatório foi deixado em branco ou está em um formato inválido!" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button_A2_DesfazerEdicao_Click(object sender, EventArgs e)
        {
            dateTimePicker_A2_DataLancamento.Value = DateTime.Now;
            textBox_A2_Valor.Clear();
            textBox_A2_Descricao.Clear();
            comboBox_A2_Categoria.SelectedItem = null;
            comboBox_A2_Conta.SelectedItem = null;
            comboBox_A2_FormaPaga.SelectedItem = null;
            textBox_A2_JurosDia.Clear();
            textBox_A2_Multa.Clear();
            //idLancamento = -1;
            button_A2_DesfazerEdicao.Visible = false;
        }

        private void button_A2_ExcluirLancamento_Click(object sender, EventArgs e)
        {
            int idLancamento = int.Parse(label_A2_IdLanca2.Text);
            Lancamento lancamento = LancamentoController.get(idLancamento);
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja remover o lançamento '" + lancamento.descricao + "' ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                LancamentoController.delete(idLancamento);
                AtualizarListaLancamentos();
            }
        }

        private void button_A2_EditarLancamento_Click(object sender, EventArgs e)
        {/*
            idLancamento = int.Parse(label_A2_IdLanca2.Text);
            Lancamento lancamento = LancamentoController.get(idLancamento);
            panel_A2_BarStatus.BackColor = Color.Blue;

            dateTimePicker_A2_DataLancamento.Value = lancamento.dataLancamento;
            textBox_A2_Valor.Text = lancamento.valor.ToString();
            textBox_A2_Descricao.Text = lancamento.descricao;

            using (OikoDataContext bd = new OikoDataContext())
            {
                var consulta = from c in bd.Categoria
                               where c.tipo == lancamento.tipo
                               select new { c.id, c.nome };
                categoriaBindingSource.DataSource = consulta;
            }

            if (lancamento.tipo == "Receita")
            {
                button_A2_Despesa.Enabled = false;
                button_A2_Receita.Enabled = true;
                label_A2_FormaPaga.Enabled = false;
                comboBox_A2_FormaPaga.Enabled = false;
            }
            else
            {
                button_A2_Despesa.Enabled = true;
                button_A2_Receita.Enabled = false;
                label_A2_FormaPaga.Enabled = true;
                comboBox_A2_FormaPaga.Enabled = true;
                comboBox_A2_FormaPaga.SelectedValue = Convert.ToInt32(lancamento.idFormaPagamento);
            }
            comboBox_A2_Categoria.SelectedValue = lancamento.idCategoria;
            button_A2_DesfazerEdicao.Visible = true;*/
        }
        #endregion

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

        public void AtualizarListaLancamentos(System.Linq.IQueryable lista)
        {
            listView_A2_Lancamentos.Items.Clear();
            foreach (Lancamento lancamento in lista)
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

        private void listView_A2_Lancamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idLancamento = int.Parse(listView_A2_Lancamentos.FocusedItem.SubItems[0].Text);
            Lancamento lancamento = LancamentoController.get(idLancamento);

            if (lancamento.tipo == "Receita")
            {
                panel_A2_BarStatus2.BackColor = Color.Green;
            }
            else
            {
                panel_A2_BarStatus2.BackColor = Color.Red;
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
            }
            else
            {
                button_A2_BaixaLancamento.Enabled = false;
            }
            button_A2_EditarLancamento.Enabled = true;
            button_A2_ExcluirLancamento.Enabled = true;
        }

        private void button_A2_BaixaLancamento_Click(object sender, EventArgs e)
        {
            tabControl_A2_DetalhesLancamento.TabPages.Clear();
            tabControl_A2_DetalhesLancamento.TabPages.Add(tabPage_A2_BaixaLancamento);
        }

        private void comboBox_A2_Contas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_A2_DataLancamento.Value > DateTime.Now)
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

        private void comboBox_A2_TipoLanc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_A2_TipoLanc.Text == "Todos")
            {
                categoriaBindingSource1.DataSource = null;
            }
            else
            {
                string tipoLancamento = comboBox_A2_TipoLanc.Text;
                using (OikoDataContext bd = new OikoDataContext())
                {
                    var consulta = from c in bd.Categoria
                                   where c.tipo == tipoLancamento
                                   select new { c.id, c.nome };
                    categoriaBindingSource1.DataSource = consulta;
                }
            }
        }

        public void limparCampos()
        {
            foreach (Control controle in tabPage_A2_NovoLancamento.Controls)
            {
                if (controle is TextBox)
                    ((TextBox)controle).Clear();
                else if (controle is ComboBox)
                    ((ComboBox)controle).SelectedItem = null;
            }
            
            dateTimePicker_A2_DataLancamento.Value = DateTime.Now;
            button_A2_Receita.Enabled = true;
            button_A2_Despesa.Enabled = true;
            panel_A2_BarStatus.BackColor = Color.DarkGray;
        }

        private void button_A2_Filtrar_Click(object sender, EventArgs e)
        {
            DateTime dataInicial = dateTimePicker_A2_DataInicial.Value;
            DateTime dataFinal = dateTimePicker_A2_DataFinal.Value;
            if (comboBox_A2_TipoLanc.Text == "Todos")
            {
                using (OikoDataContext bd = new OikoDataContext())
                {
                    var consulta = from c in bd.Lancamento
                                   where c.dataLancamento > dataInicial
                                   && c.dataLancamento > dataInicial
                                   select c;
                    AtualizarListaLancamentos(consulta);
                }
            }
            else
            {
                int idCategoria = Convert.ToInt32(comboBox_A2_TipoCateg.SelectedValue);
                using (OikoDataContext bd = new OikoDataContext())
                {
                    var consulta = from c in bd.Lancamento
                                   where c.dataLancamento > dataInicial
                                   && c.dataLancamento > dataInicial
                                   && c.idCategoria == idCategoria
                                   select c;
                    AtualizarListaLancamentos(consulta);
                }
            }
        }

        public void habilitarReceita()
        {
            button_A2_Despesa.Enabled = true;
            button_A2_Receita.Enabled = false;
            label_A2_FormaPaga.Enabled = false;
            comboBox_A2_FormaPaga.Enabled = false;

            using (OikoDataContext bd = new OikoDataContext())
            {
                var consulta = from c in bd.Categoria
                               where c.tipo == "Receita"
                               select new { c.id, c.nome };
                categoriaBindingSource.DataSource = consulta;
            }
            panel_A2_BarStatus.BackColor = Color.Green;
        }

        public void habilitarDespesa()
        {
            button_A2_Despesa.Enabled = false;
            button_A2_Receita.Enabled = true;
            label_A2_FormaPaga.Enabled = true;
            comboBox_A2_FormaPaga.Enabled = true;

            using (OikoDataContext bd = new OikoDataContext())
            {
                var consulta = from c in bd.Categoria
                               where c.tipo == "Despesa"
                               select new { c.id, c.nome };
                categoriaBindingSource.DataSource = consulta;
            }
            panel_A2_BarStatus.BackColor = Color.Red;
        }

        private void button_A2_ConcluirBaixa_Click(object sender, EventArgs e)
        {
            int idLancamento = int.Parse(label_A2_IdLanca2.Text);
            DateTime dataRecebimentoPagamento = dateTimePicker_A2_DataRecebimentoPagamento.Value;
            int idConta = Convert.ToInt32(comboBoxContaOrigemRecebimento.SelectedValue);

            LancamentoController.baixa(idLancamento, dataRecebimentoPagamento, idConta);
            MessageBox.Show("Lançamento atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl_A2_DetalhesLancamento.TabPages.Clear();
            tabControl_A2_DetalhesLancamento.TabPages.Add(tabPage_A2_DetalhesLancamento);
            AtualizarListaLancamentos();
        }

    }
}
