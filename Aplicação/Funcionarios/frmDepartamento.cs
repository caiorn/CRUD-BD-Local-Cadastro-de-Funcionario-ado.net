using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Funcionarios.Model;
using Funcionarios.Others;

namespace Funcionarios
{
    public partial class frmDepartamento : Form
    {
        int idAlterar;
        
        public frmDepartamento()
        {
            InitializeComponent();
            ExibirDepartamentosListView();
            txtNomeDepart.Focus();
        }

        #region Eventos (7)
        private void btnCadastrarDepartamento_Click(object sender, EventArgs e)
        {
            Button botao = (sender as Button);
            try
            {
                Departamento departamento = new Departamento(txtNomeDepart.Text);

                if (botao.Text.Contains("Cadastrar"))
                {
                    departamento.Cadastrar();
                    MessageBox.Show("Cadastrado com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeDepart.Text = string.Empty;
                    ExibirDepartamentosListView();
                }
                else if (botao.Text.Contains("Salvar"))
                {
                    departamento.Id_D = idAlterar;
                    departamento.SalvarAlteracoes();
                    MessageBox.Show("Alterado com Sucesso", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    botao.Text = "Cadastrar";
                    btnCalcelarAlteracao.Visible = false;

                    //pega o indice da primeira coluna onde tem o textp Id
                    ListViewItem linhaAlterada = listView1.FindItemWithText(idAlterar.ToString(), false, 0);
                    //altero o texto do SubItem da linha
                    linhaAlterada.SubItems[1].Text = departamento.Nome;
                    myDefaultColorListView();
                }
                txtNomeDepart.Text = "";
            }
            catch (ExceptionNomeVazio ex)
            {
                MessageBox.Show(ex.Message, "Campo Nome VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ExceptionRegistroExistente ex)
            {
                MessageBox.Show(ex.Message, "Registro ja Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarDepartamento_Click(object sender, EventArgs e)
        {
            if (idAlterar > 0)
                btnCalcelarAlteracao_Click(null, null);

            int numTest;
            if (int.TryParse(txtNomeDepart.Text, out numTest))
                ExibirDepartamentosListView(FiltrarPor.Id);
            else
                ExibirDepartamentosListView(FiltrarPor.Nome);
        }

        private void btnExcluirDepartamento_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecione um Departamento para poder Excluir", "Nenhum Selecionado");
                return;
            }
            if (idAlterar > 0)
                btnCalcelarAlteracao_Click(sender, e);

            Departamento departamento = new Departamento();
            departamento.Id_D = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            departamento.Nome = listView1.SelectedItems[0].SubItems[1].Text;

            if (DialogResult.No == MessageBox.Show("Tem Certeza que deseja excluir o Departamento " + departamento.Nome + " ?", "Realmente deseja apagar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;

            try
            {
                departamento.Excluir();
                listView1.SelectedItems[0].Remove();
                myDefaultColorListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarDepartamento_Click(object sender, EventArgs e)
        {
            myDefaultColorListView();

            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecione um Departamento para poder Alterar", "Nenhum Selecionado");
                return;
            }

            idAlterar = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtNomeDepart.Text = listView1.SelectedItems[0].SubItems[1].Text;
            btnCadastrarDepartamento.Text = "Salvar";
            btnCalcelarAlteracao.Visible = true;

            listView1.SelectedItems[0].BackColor = Color.Orange;
            listView1.SelectedItems.Clear();
        }

        private void btnCalcelarAlteracao_Click(object sender, EventArgs e)
        {
            idAlterar = 0;
            btnCadastrarDepartamento.Text = "Cadastrar";
            btnCalcelarAlteracao.Visible = false;
            myDefaultColorListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conjunto com evento leavel panel1 para funcionamento corretamento
            int qntSelecionado = listView1.SelectedItems.Count;
            bool habilitado = false;

            if (qntSelecionado == 1)
                habilitado = true;
            else if (qntSelecionado != 1)
                habilitado = false;

            btnExcluirDepartamento.Enabled = habilitado;
            btnAlterarDepartamento.Enabled = habilitado;
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
        }
        #endregion

        #region Métodos (2)
        private void ExibirDepartamentosListView(FiltrarPor tipoFiltro = FiltrarPor.Nome)
        {
            listView1.Items.Clear();
            try
            {
                if (tipoFiltro == FiltrarPor.Nome)
                {
                    List<Departamento> departamentos = Departamento.BuscarDepartamentos(txtNomeDepart.Text);
                    for (int i = 0; i < departamentos.Count; i++)
                    {
                        listView1.Items.Add(departamentos[i].Id_D.ToString());
                        listView1.Items[i].SubItems.Add(departamentos[i].Nome);
                    }
                }
                else  //FiltrarPor.Id
                { 
                    Departamento departamento = Departamento.BuscarDepartamentoPorId(int.Parse(txtNomeDepart.Text));
                    listView1.Items.Add(departamento.Id_D.ToString());
                    listView1.Items[0].SubItems.Add(departamento.Nome);
                }

                myDefaultColorListView();
                listView1.SelectedItems.Clear();
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Não possui nenhum departamento cadastrado!"))
                    MessageBox.Show(ex.Message, "Nenhum departamento na base de dados");
                else
                    MessageBox.Show(ex.Message, "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void myDefaultColorListView()
        {
            for (int i = 0; i < listView1.Items.Count; i++)            
                if (i % 2 == 0)
                    listView1.Items[i].BackColor = Color.LightGray;
                else
                    listView1.Items[i].BackColor = Color.Transparent;            
        }
        #endregion
    }
}
