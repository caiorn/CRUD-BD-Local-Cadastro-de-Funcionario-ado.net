using System;
using System.Windows.Forms;

using Funcionarios.Model;
using Funcionarios.Others;

namespace Funcionarios
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            //Inicia a classe para criação do banco de dados
            Funcionarios.Persistence.ConfigSqlCE criacaoBanco = new Persistence.ConfigSqlCE();

            AtualizarDadosFiltroAvancado();
            AtualizarDadosDataGrid(FiltrarPor.Nome);
            AtualizarLabelQntExibidosECadastrados();
        }

        #region Eventos (10)
        private void btnsNovoAlterarConsultarFunc_Click(object sender, EventArgs e)
        {
            string buttonTag = (sender as Button).Tag.ToString();

            if (buttonTag == "Novo")
            {
                new frmFuncionario(0, this).Show();
            }
            else
            {
                if (dgvFuncionarios.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um funcionario");
                    return;
                }
                int idFuncGrid = Convert.ToInt16(dgvFuncionarios.CurrentRow.Cells[0].Value);

                if (buttonTag == "Alterar")//Passa o id positivo para o construtor       
                    new frmFuncionario(idFuncGrid, this).Show();
                else if (buttonTag == "Consultar")//Passa o id negativo
                    new frmFuncionario(idFuncGrid * -1, this).Show();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione um funcionario");
                return;
            }
            Funcionario funcionario = new Funcionario();
            funcionario.Id_F = Convert.ToInt32(dgvFuncionarios.CurrentRow.Cells[0].Value);
            try
            {
                funcionario.Excluir();
                funcionario.ExcluirFoto(Funcionarios.Persistence.ConfigSqlCE.pastaFotos);
                MessageBox.Show("Apagado com Sucesso!", "Excluido");
                dgvFuncionarios.Rows.RemoveAt(this.dgvFuncionarios.SelectedRows[0].Index);
                AtualizarLabelQntExibidosECadastrados();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void chksDataAdimissaoESalario_CheckedChanged(object sender, EventArgs e)
        {
            txtSalarioMin.Enabled = chkAtivaFiltroSalario.Checked;
            txtSalarioMax.Enabled = chkAtivaFiltroSalario.Checked;
            dtpDataAdmissaoMin.Enabled = chkComDatasAdmissao.Checked;
            dtpDataAdmissaoMax.Enabled = chkComDatasAdmissao.Checked;
        }

        private void chkFiltroAvançado_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkFiltroAvançado.Checked;
            btnPesquisarFuncionario.Visible = isChecked;
            groupBox1.Enabled = isChecked;

            FiltrarPor filtro = VerificaoInteligente();
            if (!isChecked)
                AtualizarDadosDataGrid(filtro);
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarPor filtro = VerificaoInteligente();
            if (chkFiltroAvançado.Checked)
                return;
            AtualizarDadosDataGrid(filtro);
        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            AtualizarDadosDataGrid(VerificaoInteligente());
        }        

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tsmi = (sender as ToolStripMenuItem);
            dgvFuncionarios.Columns[tsmi.Tag.ToString()].Visible = tsmi.Checked;
        }

        private void txtSalarioMinMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            Reaproveitamento.ApenasNumeros(e);
        }

        private void txtSalarioMinMax_TextChanged(object sender, EventArgs e)
        {
            TextBox txtSalarioMinEMax = (sender as TextBox);
            Reaproveitamento.FormatoMoeda(ref txtSalarioMinEMax);
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnsNovoAlterarConsultarFunc_Click(btnConsultarFunc, null);
        }
        #endregion

        #region Métodos (4)
        public void AtualizarDadosFiltroAvancado()
        {
            //carrega o combobox
            cboDepartamentos.DataSource = Departamento.BuscarNomeTodosDepartamentos("Todos(Com ou Sem)", "Sem Departamentos", "Todos Departamentos");

            float maiorSalario, menorSalario;
            DateTime maiorDataAd, menorDataAd;
            //busca o maior e menor salario e data cadastrados
            Funcionario.BuscarMaiorMenorSalarioEData(out maiorSalario, out menorSalario, out maiorDataAd, out menorDataAd);
            txtSalarioMax.Text = maiorSalario.ToString("N2");
            txtSalarioMin.Text = menorSalario.ToString("N2");
            dtpDataAdmissaoMin.Value = menorDataAd;
            dtpDataAdmissaoMax.Value = maiorDataAd;
        }

        public void AtualizarDadosDataGrid(FiltrarPor filtro)
        {
            try
            {
                if (chkFiltroAvançado.Checked)
                {
                    bool ativo = chkAtivos.Checked;
                    bool inativo = chkInativos.Checked;
                    char sexoF = chkFeminino.Checked ? 'F' : 'M';
                    char sexoM = chkMasculino.Checked ? 'M' : 'F';
                    DateTime dataMinAd = dtpDataAdmissaoMin.Value;
                    DateTime dataMaxAd = dtpDataAdmissaoMax.Value;
                    bool semDatas = chkSemDatasAdmissao.Checked;
                    bool comDatas = chkComDatasAdmissao.Checked;
                    float salarioMin = chkAtivaFiltroSalario.Checked ? float.Parse(txtSalarioMin.Text) : 0f;
                    float salarioMax = chkAtivaFiltroSalario.Checked ? float.Parse(txtSalarioMax.Text) : 99999999f;
                    string departamento = cboDepartamentos.Text;

                    dgvFuncionarios.DataSource = Funcionario.BuscarFuncionario(filtro, txtPesquisa.Text, ativo, inativo, sexoF, sexoM, dataMinAd, dataMaxAd, semDatas, comDatas, salarioMin, salarioMax, departamento);
                }
                else
                {
                    dgvFuncionarios.DataSource = Funcionario.BuscarFuncionario(filtro, txtPesquisa.Text);
                }
                dgvFuncionarios.ClearSelection();
                AtualizarLabelQntExibidosECadastrados(qtdCadastrados: false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Faz as verificaçoes e Altera o nome da lblPesquisa para o tipo de pesquisa a ser realizado
        /// </summary>
        /// <returns>object enum FiltrarPor</returns>
        private FiltrarPor VerificaoInteligente()
        {
            long numTest;
            string text = txtPesquisa.Text.Replace(".", "").Replace("-", "");
            bool soContemNumeros = long.TryParse(text, out numTest);

            if (txtPesquisa.Text == "")
            {
                lblPesquisa.Text = "Pesquisa por Todos";
                return FiltrarPor.Nome;
            }
            else if (chkFiltroAvançado.Checked && soContemNumeros || txtPesquisa.TextLength > 2 && soContemNumeros)
            {
                lblPesquisa.Text = "Pesquisa por CPF";
                return FiltrarPor.Cpf;
            }
            else if (txtPesquisa.TextLength < 3 && soContemNumeros)
            {
                lblPesquisa.Text = "Pesquisa por ID";
                return FiltrarPor.Id;
            }
            else //Contem Letras
            {
                lblPesquisa.Text = "Pesquisa por Nome";
                return FiltrarPor.Nome;
            }
        }

        public void AtualizarLabelQntExibidosECadastrados(bool qtdCadastrados = true, bool qtdExibidos = true)
        {
            if (qtdExibidos)
                lblQtdRegistrosExibidos.Text = "Qtd Registros Exibidos: " + dgvFuncionarios.Rows.Count.ToString();
            if (qtdCadastrados)
                lblTotalCadastrados.Text = "Total Cadastrados: " + Funcionario.TotalDeFuncionariosCadastrados().ToString();
        }
        #endregion

    }
}
