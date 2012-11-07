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
    public partial class Preferencias : Form
    {
        int idCategoria = -1; // Armazena o id da categoria selecionada
        int idConta = -1; // Armazena o id da conta selecionada
        int idFormaPagamento = -1; // Armazena o id formaPagamento selecionada

        public Preferencias()
        {
            InitializeComponent();
            CarregarDadosUsuario();
        }

        public Preferencias(string opcao)
            : base()
        {
            InitializeComponent();
            switch (opcao)
            {
                case "categoria":
                    {
                        tabControl_Menu_Cadastros.SelectedTab = tabPage_PrefeA2_Categorias;
                        AtualizarListaCategorias();
                        break;
                    }
                case "conta":
                    {
                        tabControl_Menu_Cadastros.SelectedTab = tabPage_PrefeA3_Contas;
                        AtualizarListaContas();
                        break;
                    }
                case "formasPagamento":
                    {
                        tabControl_Menu_Cadastros.SelectedTab = tabPage_PrefeA4_FormaPaga;
                        AtualizarListaFormasPagamento();
                        break;
                    }
            }
        }

        // --- Evento tabControl_Menu_Cadastros_SelectedIndexChanged ---
        // Ocorre quando há mudança de abas dentro de tabControl_Menu_Cadastros
        private void tabControl_Menu_Cadastros_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl_Menu_Cadastros.SelectedIndex)
            {
                case 0: // aba usuário
                    {
                        CarregarDadosUsuario();
                        break;
                    }
                case 1: // aba categorias
                    {
                        AtualizarListaCategorias();
                        break;
                    }
                case 2: // aba contas
                    {
                        AtualizarListaContas();
                        break;
                    }
                case 3: // aba formas de pagamento
                    {
                        AtualizarListaFormasPagamento();
                        break;
                    }
            }
        }

        // -------- INICIO - Aba de Usuario --------

        // --- Botão Salvar ---
        // Salva os dados do usuário que foram atualizados ou cria um novo usuário caso ainda não exista.
        private void button_Prefe_A1_Salvar_Click(object sender, EventArgs e)
        {
            string nome = textBox_PrefeA1_NomeUsuario.Text;
            string email = textBox_PrefeA1_Email.Text;
            string login = textBox_PrefeA1_Login.Text;
            string senha = textBox_PrefeA1_Senha.Text;

            try
            {
                Usuario usuario = UsuarioController.getUsuario(0);
                UsuarioController.updateUsuario(0, nome, email, login, senha);
                MessageBox.Show("Dados atualizados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                UsuarioController.addUsuario(0, nome, email, login, senha);
                MessageBox.Show("Usuário criado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // --- Método CarregarDadosUsuario() ---
        // Carrega os dados atuais do usuário
        public void CarregarDadosUsuario()
        {
            Usuario usuario = UsuarioController.getUsuario(0);

            textBox_PrefeA1_NomeUsuario.Text = usuario.nome;
            textBox_PrefeA1_Email.Text = usuario.email;
            textBox_PrefeA1_Login.Text = usuario.login;
            textBox_PrefeA1_Senha.Text = usuario.senha;
        }

        // -------- FIM - Aba de Usuario --------

        // -------- INICIO - Aba de Categoria --------

        // --- Botão Gravar ---
        // Verifica se a categoria é nova ou é editada a partir do atributo idCategoria, se ela tiver valor -1 quer dizer a categoria é nova.
        private void buttonGravarCategoria_Click(object sender, EventArgs e)
        {
            string nome = textBox_PrefeA2_NomeCatego.Text;
            string tipo = comboBox_PrefeA2_TipoCatego.Text;

            if (idCategoria < 0)
            {
                CategoriaController.addCategoria(nome, tipo);
                MessageBox.Show("Categoria adicionada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                CategoriaController.updateCategoria(idCategoria, nome, tipo);
                MessageBox.Show("Categoria atualizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AtualizarListaCategorias();
            button_PrefeA2_GravarCategoria.Enabled = false;
            button_PrefeA2_RemoverCatego.Enabled = false;
            limparCamposCategoria();
        }

        // --- Botão NovaCategoria ---
        // Prepara o formulário para receber uma nova categoria.
        private void buttonNovaCategoria_Click(object sender, EventArgs e)
        {
            limparCamposCategoria();
            idCategoria = -1;
            button_PrefeA2_GravarCategoria.Enabled = true;
            button_PrefeA2_RemoverCatego.Enabled = false;
        }

        // --- Botão Remover ---
        // Remove a categoria da lista
        private void buttonRemoverCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = CategoriaController.getCategoria(idCategoria);
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja remover a categoria " + categoria.nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                CategoriaController.deleteCategoria(idCategoria);
                AtualizarListaCategorias();
                limparCamposCategoria();
                MessageBox.Show("Categoria removida com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_PrefeA2_GravarCategoria.Enabled = false;
                button_PrefeA2_RemoverCatego.Enabled = false;
            }
        }

        // --- Evento listViewCategorias_SelectedIndexChanged ---
        // Ocorre quando um item da lista categorias é selecionado
        // Terá como objetivo buscar a categoria selecionada a partir do id da mesma e prepará-la para edição.
        private void listViewCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCategoria = int.Parse(listView_PrefeA2_Categorias.FocusedItem.SubItems[0].Text);
            Categoria categoria = CategoriaController.getCategoria(idCategoria);
            button_PrefeA2_GravarCategoria.Enabled = true;
            button_PrefeA2_RemoverCatego.Enabled = true;

            textBox_PrefeA2_NomeCatego.Text = categoria.nome;
            comboBox_PrefeA2_TipoCatego.Text = categoria.tipo;
        }

        // --- Método AtualizarListaCategorias() ---
        // Realiza um refresh da lista de categorias, destruindo a lista e reconstruindo-a.
        private void AtualizarListaCategorias()
        {
            listView_PrefeA2_Categorias.Items.Clear();
            foreach (Categoria categoria in CategoriaController.All())
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    categoria.id.ToString(),
                    categoria.nome,
                    categoria.tipo
                });
                listView_PrefeA2_Categorias.Items.Add(item);
            }
        }

        // --- Método limparCamposCategoria() ---
        // Limpa os campos do formulário categoria
        public void limparCamposCategoria()
        {
            textBox_PrefeA2_NomeCatego.Clear();
            comboBox_PrefeA2_TipoCatego.Text = "Escolha uma opção...";
        }

        // -------- FIM - Aba de Categoria --------

        // -------- INICIO - Aba de Contas --------

        // --- Botão Gravar ---
        // Verifica se a conta é nova ou é editada a partir do atributo idConta, se ela tiver valor -1 quer dizer a conta é nova.
        private void buttonGravarConta_Click(object sender, EventArgs e)
        {
            string nome = textBox_Prefe_A3_NomeConta.Text;
            bool saldoNegativo = checkBoxSaldoNegativo.Checked;

            if (idConta < 0)
            {
                decimal saldo = decimal.Parse(textBox_Prefe_A3_Saldo.Text);
                if (saldo < 0)
                {
                    if (!saldoNegativo)
                    {
                        MessageBox.Show("Esta conta está configurada para não permitir saldo negativo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                ContaController.addConta(nome, saldo, saldoNegativo);
                MessageBox.Show("Conta adicionada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                ContaController.updateConta(idConta, nome, saldoNegativo);
                MessageBox.Show("Conta atualizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AtualizarListaContas();
            limparCamposConta();
        }

        // --- Botão NovaCategoria ---
        // Prepara o formulário para receber uma nova categoria.
        private void buttonNovaConta_Click(object sender, EventArgs e)
        {
            limparCamposConta();
            idConta = -1;
            buttonGravarConta.Enabled = true;
            textBox_Prefe_A3_Saldo.Enabled = true;
        }

        // --- Botão Remover ---
        // Remove a conta da lista
        private void buttonRemoverConta_Click(object sender, EventArgs e)
        {
            Conta conta = ContaController.getConta(idConta);
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja remover a conta " + conta.nome + "?\nTodo o saldo atual da conta será perdido!", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                ContaController.deleteConta(idConta);
                AtualizarListaContas();
                limparCamposConta();
                MessageBox.Show("Conta removida com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- Evento textBox_Prefe_A3_Saldo_Enter ---
        // Ocorre quando a textBox_Prefe_A3_Saldo é acionada
        private void textBox_Prefe_A3_Saldo_Enter(object sender, EventArgs e)
        {
            textBox_Prefe_A3_Saldo.Clear();
        }

        // --- Evento textBox_Prefe_A3_Saldo_Leave ---
        // Ocorre ao sair da textBox_Prefe_A3_Saldo
        private void textBox_Prefe_A3_Saldo_Leave(object sender, EventArgs e)
        {
            if (textBox_Prefe_A3_Saldo.Text == "")
            {
                textBox_Prefe_A3_Saldo.Text = "Exemplo: 100,00 ou -100,00";
            }
        }

        // --- Evento listViewCategorias_SelectedIndexChanged ---
        // Ocorre quando um item da lista contas é selecionado
        // Terá como objetivo buscar a conta selecionada a partir do id da mesma e prepará-la para edição.
        private void listViewContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            idConta = int.Parse(listViewContas.FocusedItem.SubItems[0].Text);
            Conta conta = ContaController.getConta(idConta);
            buttonGravarConta.Enabled = true;
            buttonRemoverConta.Enabled = true;
            textBox_Prefe_A3_Saldo.Enabled = false;

            textBox_Prefe_A3_NomeConta.Text = conta.nome;
            checkBoxSaldoNegativo.Checked = (bool)conta.saldoNegativo;
        }

        // --- Método AtualizarListaContas() ---
        // Realiza um refresh da lista de contas, destruindo a lista e reconstruindo-a.
        public void AtualizarListaContas()
        {
            listViewContas.Items.Clear();
            foreach (Conta conta in ContaController.All())
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    conta.id.ToString(),
                    conta.nome,
                    conta.saldo.ToString(),
                    conta.saldoNegativo == true ? "Sim" : "Não"
                });
                listViewContas.Items.Add(item);
            }
        }

        // --- Método limparCamposConta() ---
        // Limpa os campos do formulário conta
        public void limparCamposConta()
        {
            buttonGravarConta.Enabled = false;
            buttonRemoverConta.Enabled = false;
            checkBoxSaldoNegativo.Checked = false;
            textBox_Prefe_A3_NomeConta.Clear();
            textBox_Prefe_A3_Saldo.Text = "Exemplo: 100,00 ou -100,00";
        }

        // -------- FIM - Aba de Contas --------

        // -------- INICIO - Aba de Formas de Pagamento --------

        // --- Botão Gravar ---
        // Verifica se a formaPagamento é nova ou é editada a partir do atributo idFormaPagamento, se ela tiver valor -1 quer dizer a formaPagamento é nova.
        private void buttonGravarFormaPagamento_Click(object sender, EventArgs e)
        {
            string nome = textBoxFormaPagamento.Text;

            if (idFormaPagamento < 0)
            {
                FormaPagamentoController.addFormaPagamento(nome);
                MessageBox.Show("FormaPagamento adicionada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                FormaPagamentoController.updateFormaPagamento(idFormaPagamento, nome);
                MessageBox.Show("FormaPagamento atualizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AtualizarListaFormasPagamento();
            buttonGravarFormaPagamento.Enabled = false;
            buttonRemoverFormaPagamento.Enabled = false;
            limparCamposFormaPagamento();
        }

        // --- Botão NovaFormaPagamento ---
        // Prepara o formulário para receber uma nova formaPagamento.
        private void buttonNovaFormaPagamento_Click(object sender, EventArgs e)
        {
            limparCamposFormaPagamento();
            idFormaPagamento = -1;
            buttonGravarFormaPagamento.Enabled = true;
            buttonRemoverFormaPagamento.Enabled = false;
        }

        // --- Botão Remover ---
        // Remove a formaPagamento da lista
        private void buttonRemoverFormaPagamento_Click(object sender, EventArgs e)
        {
            FormaPagamento formaPagamento = FormaPagamentoController.getFormaPagamento(idFormaPagamento);
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja remover a formaPagamento " + formaPagamento.nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                FormaPagamentoController.deleteFormaPagamento(idFormaPagamento);
                AtualizarListaFormasPagamento();
                limparCamposFormaPagamento();
                MessageBox.Show("FormaPagamento removida com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonGravarFormaPagamento.Enabled = false;
                buttonRemoverFormaPagamento.Enabled = false;
            }
        }

        // --- Evento listViewFormasPagamento_SelectedIndexChanged ---
        // Ocorre quando um item da lista formasPagamento é selecionado
        // Terá como objetivo buscar a formaPagamento selecionada a partir do id da mesma e prepará-la para edição.
        private void listViewFormasPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            idFormaPagamento = int.Parse(listViewFormasPagamento.FocusedItem.SubItems[0].Text);
            FormaPagamento formaPagamento = FormaPagamentoController.getFormaPagamento(idFormaPagamento);
            buttonGravarFormaPagamento.Enabled = true;
            buttonRemoverFormaPagamento.Enabled = true;

            if (formaPagamento != null)
            {
                textBoxFormaPagamento.Text = formaPagamento.nome;
            }
        }

        // --- Método AtualizarListaFormasPagamento() ---
        // Realiza um refresh da lista de formasPagamento, destruindo a lista e reconstruindo-a.
        private void AtualizarListaFormasPagamento()
        {
            listViewFormasPagamento.Items.Clear();
            foreach (FormaPagamento formaPagamento in FormaPagamentoController.All())
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    formaPagamento.id.ToString(),
                    formaPagamento.nome,
                });
                listViewFormasPagamento.Items.Add(item);
            }
        }

        // --- Método limparCamposFormaPagamento() ---
        // Limpa os campos do formulário formaPagamento
        public void limparCamposFormaPagamento()
        {
            textBoxFormaPagamento.Clear();
        }

        private void Preferencias_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        // -------- FIM - Aba de Formas de Pagamento --------
    }
}
