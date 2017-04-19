using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

using Funcionarios.Model;
using Funcionarios.Others;

namespace Funcionarios
{

    public partial class frmFuncionario : Form
    {
        private string nomeFoto { get; set; }
        public short idAlterar { get; set; }
        public frmMain frmPai { get; set; }

        public frmFuncionario(int idFuncionario, frmMain formPai)//0(neutro) = novo, -24(negativo) = consulta, 24(positivo) = alteracao
        {
            InitializeComponent();
            frmPai = formPai;
            idAlterar = (short)idFuncionario;

            if(idFuncionario > 0) //Alterar
            {
                this.Text = "Alteração de Funcionario";
                btnCadastrarOuAlterar.Text = "Salvar Alteraçoes";
            }
            else if(idFuncionario < 0) //Consultar (o id virá negativo)
            {
                this.Text = "Consulta de Funcionario";
                btnCadastrarOuAlterar.Text = "Alterar";
                groupBox1.Enabled = false;
            }//senao é Novo e idAlterar = 0;
        }
        
        #region Eventos(15)
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                cboDepartamentos.DataSource = Departamento.BuscarNomeTodosDepartamentos("");
                
                if(idAlterar > 0 || idAlterar < 0)//Alterar ou Consultar
                    ExibirFuncionario();
                else
                    txtIdFunc.Text = Funcionario.BuscarProxIdACadastrar().ToString();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPEG|*.jpg;*.jpeg|PNG|*.png|Arquivos Bitmap|*.bmp|Todos Arquivos|*.*|Arquivos de Imagem|*.jpg;*.jpeg;*.bmp;*.png;*.gif",
                Multiselect = false,
                Title = "Escolher Foto"
            })
            {
                ofd.FilterIndex = ofd.Filter.Length -1;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string diretorioFoto = ofd.FileName;
                    //Carregar a Imagem
                    pictureBox1.Image = Image.FromFile(diretorioFoto);
                    nomeFoto = diretorioFoto;
                }
            }
        }

        private void btnRemoverImagem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Refresh();
        }

        private void btnCadastrarOuAlterar_Click(object sender, EventArgs e)
        {
            if(btnCadastrarOuAlterar.Text == "Alterar")
            {
                groupBox1.Enabled = true;
                idAlterar = Math.Abs(idAlterar);
                this.Text = "Alteração de Funcionario";
                btnCadastrarOuAlterar.Text = "Salvar Alterações";
                return;
            }

            //Validaçoes
            if(txtNomeFunc.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNomeFunc, null);
                errorProvider1.SetError(txtNomeFunc, "Campo Obrigatorio");

                toolTip1.ToolTipTitle = "Campo Obrigátorio";
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.IsBalloon = true;
                toolTip1.Show("Prencha este campo", txtNomeFunc, 3000);
                return;
            }

            if(Reaproveitamento.formularioPossuiErrosDoErroProvider(groupBox1, errorProvider1))
            {
                MessageBox.Show("O formulario ainda contem erros verifique");
                return;
            }

            errorProvider1.Clear();

            //Prencher a entidade
            Funcionario funcionario = new Funcionario(){
                Id_F = idAlterar,
                Nome = txtNomeFunc.Text,
                CPF = mtxtCpfFunc.Text,                             //MinDate
                DataNascimento = mtxtDataNascFunc.Text == "  /  /" ? (DateTime?)null : DateTime.Parse(mtxtDataNascFunc.Text),
                Sexo = rbtMasculino.Checked ? 'M' : 'F',
                Celular = mtxtCelularFunc.Text,
                Email = txtEmailFunc.Text,                                                //MinDate
                DataAdmissao = dtpDataAdmissaoFunc.Enabled ? dtpDataAdmissaoFunc.Value : (DateTime?)null, //MinValue = dbType.Null, conforme class DataAcessSqlCE, Linha 62
                Departamento = Departamento.BuscarDepartamentos(cboDepartamentos.Text, true).FirstOrDefault<Departamento>()
            };
            double tempSalario;
            if(txtSalarioFunc.Text != "0,00" && double.TryParse(txtSalarioFunc.Text, out tempSalario))
                funcionario.Salario = tempSalario;//senao recebe nulo
            
            funcionario.Ativo = chkAtivo.Checked;

            //Definindo nome da imagem a gravar (o Id + o primeiro nome da pessoa)
            if(pictureBox1.Image != null)            
                if(txtNomeFunc.Text.Trim().Contains(" "))
                    funcionario.Foto = txtIdFunc.Text + txtNomeFunc.Text.Substring(0, txtNomeFunc.Text.IndexOf(" "));//Armazena o id + o primeiro nome(ate o 1º espaço)
                else
                    funcionario.Foto = txtIdFunc.Text + txtNomeFunc.Text;            
            else            
                funcionario.Foto = null;
            
            try
            {
                string endPastaFotos = Funcionarios.Persistence.ConfigSqlCE.pastaFotos;              
                if(idAlterar == 0)//Cadastra um novo funcionario
                {
                    funcionario.Cadastrar();
                    funcionario.SalvarFoto(pictureBox1.Image, endPastaFotos);

                    MessageBox.Show("Cadastrado com Sucesso", "Cadastrado");
                    Reaproveitamento.LimparTodosCampos(groupBox1);
                }
                else if(idAlterar > 0)//Altera o Funcionario
                {
                    funcionario.SalvarAlteracoes();
                    funcionario.ExcluirFoto(endPastaFotos);
                    funcionario.SalvarFoto(pictureBox1.Image, endPastaFotos);

                    MessageBox.Show("Alterado com Sucesso", "Alterado");
                }
                //Atualiza o formMain
                frmPai.AtualizarDadosFiltroAvancado();       
                frmPai.AtualizarDadosDataGrid(FiltrarPor.Nome);
                frmPai.AtualizarLabelQntExibidosECadastrados();
            }
            catch(ExceptionNomeVazio ex) { errorProvider1.SetError(txtNomeFunc, ex.Message); }
            catch(ExceptionRegistroExistente ex) { MessageBox.Show(ex.Message, "CPF EXISTENTE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAddDepartamento_Click(object sender, EventArgs e)
        {
            new frmDepartamento().ShowDialog();
            cboDepartamentos.DataSource = Departamento.BuscarNomeTodosDepartamentos();
            frmPai.AtualizarDadosFiltroAvancado();
        }

        private void txtNomeFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Reaproveitamento.ApenasLetras(e);
        }

        private void txtSalarioFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Reaproveitamento.ApenasNumeros(e);
        }

        private void txtSalarioFunc_TextChanged(object sender, EventArgs e)
        {
            Reaproveitamento.FormatoMoeda(ref txtSalarioFunc);
        }

        private void chkDataAdmisao_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataAdmissaoFunc.Enabled = chkDataAdmisao.Checked;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeFunc_Validating(object sender, CancelEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNomeFunc.Text))
                errorProvider1.SetError(txtNomeFunc, null);
        }

        private void txtEmailFunc_Validating(object sender, CancelEventArgs e)
        {
            //se tiver algum texto, e estiver no formato incorreto
            if(!string.IsNullOrWhiteSpace(txtEmailFunc.Text) && !Reaproveitamento.EmailValido(txtEmailFunc.Text))
                errorProvider1.SetError(txtEmailFunc, "Email Inválido");
            else
                errorProvider1.SetError(txtEmailFunc, null);
        }

        private void mtxtCpfFunc_Validating(object sender, CancelEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(mtxtCpfFunc.Text) && !Reaproveitamento.CPFValido(mtxtCpfFunc.Text))
                errorProvider1.SetError(mtxtCpfFunc, "CPF Inválido");
            else
                errorProvider1.SetError(mtxtCpfFunc, null);
        }

        private void mtxtDataNascFunc_Validating(object sender, CancelEventArgs e)
        {
            DateTime dataNasc;
            DateTime hoje = DateTime.Now;

            if(mtxtDataNascFunc.Text == "  /  /")
                errorProvider1.SetError(mtxtDataNascFunc, null);
            else if(!DateTime.TryParse(mtxtDataNascFunc.Text, out dataNasc))
                errorProvider1.SetError(mtxtDataNascFunc, "Data Inválida");
            else if(dataNasc > hoje)
                errorProvider1.SetError(mtxtDataNascFunc, "Impossivel você nascer no futuro!");
            else if(dataNasc.Year < hoje.Year - 120)
                errorProvider1.SetError(mtxtDataNascFunc, "Impossível você ter mais de 120 anos");
            else
                errorProvider1.SetError(mtxtDataNascFunc, null);
        }

        private void mtxtCelularFunc_Validating(object sender, CancelEventArgs e)
        {
            //se nao estiver vazio nem estiver completo
            if(mtxtCelularFunc.Text != "" && !mtxtCelularFunc.MaskCompleted)
                errorProvider1.SetError(mtxtCelularFunc, "Campo imcompleto");
            else
                errorProvider1.SetError(mtxtCelularFunc, null);
        }
        #endregion

        #region Métodos (1)
        private void ExibirFuncionario()
        {
            Funcionario funcionario = Funcionario.BuscarFuncionarioPorId(Math.Abs(idAlterar));
            txtIdFunc.Text = funcionario.Id_F.ToString();
            txtNomeFunc.Text = funcionario.Nome;
            mtxtCpfFunc.Text = funcionario.CPF;

            mtxtCelularFunc.Text = funcionario.Celular;
            mtxtDataNascFunc.Text = funcionario.DataNascimento != null ? funcionario.DataNascimento.Value.ToString("dd/MM/yyyy") : "";
            rbtFeminino.Checked = funcionario.Sexo == 'M' ? true : false;
            rbtMasculino.Checked = !rbtFeminino.Checked;
            txtEmailFunc.Text =  funcionario.Email;

            if(funcionario.DataAdmissao == null)
                chkDataAdmisao.Checked = false;
            else
            {
                dtpDataAdmissaoFunc.Value = funcionario.DataAdmissao.Value;
                chkDataAdmisao.Checked = true;
            }

            txtSalarioFunc.Text = funcionario.Salario.ToString();
            chkAtivo.Checked = funcionario.Ativo;
            cboDepartamentos.SelectedItem = funcionario.Departamento != null ? funcionario.Departamento.Nome : "";

            //busca a imagem no local
            if(!string.IsNullOrEmpty(funcionario.Foto))
            {
                string localImagem = Funcionarios.Persistence.ConfigSqlCE.pastaFotos + funcionario.Foto + ".jpg";

                if(File.Exists(localImagem))
                    pictureBox1.ImageLocation = localImagem;
                else
                    MessageBox.Show("A imagem foi Excluida diretamente da pasta de fotos\rCadastre outra Imagem ou Salve para atualização no banco de dados","A Foto não está na pasta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
