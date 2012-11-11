using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oiko.controllers;
using System.Windows.Forms.DataVisualization.Charting;

namespace Oiko
{
    public partial class Form4_VisaoGeral : Form
    {
        public Form4_VisaoGeral()
        {
            InitializeComponent();
        }

        private void Form4_VisaoGeral_Load(object sender, EventArgs e)
        {
            OikoDataContext bd = new OikoDataContext();
            contaBindingSource.DataSource = bd.Conta;

            var consulta = from c in bd.Categoria
                           where c.tipo == "Receita"
                           select new { c.id, c.nome };
            categoriaBindingSource.DataSource = consulta;

            comboBox_A1_Categorias.SelectedItem = null;
            comboBox_A1_Conta.SelectedItem = null;

            AtualizarListaContas();
            AtualizarListaContasPagarReceber();
            CarregarGraficoReceitasDespesas();
        }

        public void AtualizarListaContas()
        {
            listViewSaldos.Items.Clear();
            foreach (Conta conta in ContaController.all())
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    conta.nome,
                    conta.saldo.ToString()            
                });
                listViewSaldos.Items.Add(item);
            }
        }

        public void AtualizarListaContasPagarReceber()
        {
            listViewContasPagarReceber.Items.Clear();

            using (OikoDataContext bd = new OikoDataContext())
            {
                var consulta = from c in bd.Lancamento
                               where c.dataLancamento > DateTime.Now
                               && c.status == false
                               select c;

                foreach (Lancamento lancamento in consulta)
                {
                    ListViewItem item = new ListViewItem(new string[] { 
                    lancamento.dataLancamento.ToString("dd/MM/yyyy"),
                    lancamento.descricao,
                    lancamento.valor.ToString()
                });
                    listViewContasPagarReceber.Items.Add(item);
                }
            }
        }

        public void CarregarGraficoReceitasDespesas()
        {
            decimal somaReceita=0;
            decimal somaDespesa = 0;
            using (OikoDataContext bd = new OikoDataContext())
            {
                foreach (Lancamento lancamento in LancamentoController.all())
                {
                    if (lancamento.tipo == "Receita")
                    {
                        somaReceita += lancamento.valor;
                    }
                    else
                    {
                        somaDespesa += lancamento.valor;
                    }
                }
            }

            chartDespesasReceitas.Series[0].Points[0].SetValueY(somaReceita);
            chartDespesasReceitas.Series[1].Points[0].SetValueY(somaDespesa);
            //// Data arrays.
            //string[] seriesArray = { "Cats", "Dogs" };
            //int[] pointsArray = { 1, 2 };

            //// Set palette.
            //this.chartDespesasReceitas.Palette = ChartColorPalette.SeaGreen;

            //// Set title.
            //this.chartDespesasReceitas.Titles.Add("Pets");

            //// Add series.
            //for (int i = 0; i < seriesArray.Length; i++)
            //{
            //    // Add series.
            //    Series series = this.chartDespesasReceitas.Series.Add(seriesArray[i]);

            //    // Add point.
            //    series.Points.Add(pointsArray[i]);
            //}
        }
    }
}
