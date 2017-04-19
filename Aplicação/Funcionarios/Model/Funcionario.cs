using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Funcionarios.Others;
using Funcionarios.Persistence;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Funcionarios.Model
{
    class Funcionario
    {
        //Properties & Fields
        public int Id_F { get; set; }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome =  System.Globalization.CultureInfo.GetCultureInfo("pt-BR").TextInfo.ToTitleCase(value.ToLower()); }
        }
        public string CPF { get; set; }
        public DateTime? DataNascimento { get; set; }
        public char Sexo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
        public DateTime? DataAdmissao { get; set; }
        public bool Ativo { get; set; }
        public double? Salario { get; set; }
        //public int Id_Departamento { get; set; }  
        public Departamento Departamento { get; set; }

        //Construct
        public Funcionario()
        {

        }

        //Metodos
        public void Cadastrar()
        {
            if(string.IsNullOrEmpty(this.Nome))
                throw new ExceptionNomeVazio("O campo nome é obrigatório");

            if(cpfExiste(this.CPF))
                throw new ExceptionRegistroExistente("Já possui um Funcionario com o CPF cadastrado");

            DataAcessSqlCE acessoDados = new DataAcessSqlCE();
            acessoDados.Executar("INSERT INTO Funcionario (Nome,   CPF,   DataNascimento,   Sexo,   Celular,    Foto,      Email,   DataAdmissao,   Id_Departamento, Salario,    Ativo) VALUES",
                                                           this.Nome, this.CPF, this.DataNascimento, this.Sexo, this.Celular, this.Foto, this.Email, this.DataAdmissao, (this.Departamento == null ? (int?)null : (int?)this.Departamento.Id_D), this.Salario, this.Ativo);
        }

        public void SalvarAlteracoes()
        {
            if(string.IsNullOrEmpty(this.Nome))
                throw new ExceptionNomeVazio("O campo nome é obrigatório");

            DataAcessSqlCE acessoDados = new DataAcessSqlCE();
            string cpfOld = acessoDados.ObterUnicoValor("SELECT CPF FROM Funcionario WHERE Id_F = @id", this.Id_F).ToString();
            if(cpfOld != this.CPF && cpfExiste(this.CPF))
                throw new ExceptionRegistroExistente("Já possui um Funcionario com o CPF cadastrado");


            acessoDados.Executar("UPDATE Funcionario SET Nome, CPF, DataNascimento, Sexo, Celular, Foto, Email, DataAdmissao, Id_Departamento, Salario, Ativo " +
                                 "WHERE Id_F = @idfunc", this.Id_F,
                                                         this.Nome, this.CPF, this.DataNascimento, this.Sexo, this.Celular, this.Foto, this.Email, this.DataAdmissao, (this.Departamento == null ? (int?)null : (int?)this.Departamento.Id_D), this.Salario, this.Ativo);
        }

        public void Excluir()
        {
            if(this.Id_F == 0)
                throw new Exception("É necessario a identificação do Id para Exclusão!");

            DataAcessSqlCE acessoDados = new DataAcessSqlCE();
            acessoDados.Executar("DELETE FROM Funcionario WHERE Id_F = @id", this.Id_F);
        }

        public void SalvarFoto(Image img, string pasta)
        {
            //Se haver image e for muito grande renderiza e salva
            if(img != null)
                if(img.Width > 200 || img.Height > 400)
                    Funcionarios.Others.Reaproveitamento.ScaleImage(img, 200, 400).Save(pasta+this.Foto+".jpg", System.Drawing.Imaging.ImageFormat.Png);//Salva a imagem reduzida
                else
                    img.Save(pasta+this.Foto+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void ExcluirFoto(string pasta)
        {
            string[] files = System.IO.Directory.GetFiles(pasta, this.Id_F+"*.jpg", System.IO.SearchOption.TopDirectoryOnly);
            if(files.Length > 0)
                System.IO.File.Delete(files[0]);
        }

        public static int BuscarProxIdACadastrar()
        {
            DataAcessSqlCE acessoDados = new DataAcessSqlCE();
            string query = @"SELECT AUTOINC_NEXT 
                                FROM INFORMATION_SCHEMA.COLUMNS 
                                WHERE TABLE_NAME='Funcionario' 
                                AND COLUMN_NAME='Id_F'";

            return Convert.ToInt32(acessoDados.ObterUnicoValor(query));
        }

        public static int TotalDeFuncionariosCadastrados()
        {
            DataAcessSqlCE acessoDados = new DataAcessSqlCE();
            string query = "SELECT COUNT(Id_F) FROM Funcionario";
            return Convert.ToInt32(acessoDados.ObterUnicoValor(query));
        }

        public static DataTable BuscarFuncionario(FiltrarPor filtro, object idNomeOuCpf)
        {
            string query = "";
            idNomeOuCpf = filtro == FiltrarPor.Id ? idNomeOuCpf : "%"+idNomeOuCpf+"%";

            if(filtro == FiltrarPor.Nome)
                query = "SELECT TOP(50) * FROM Funcionario WHERE Nome LIKE @nome ORDER BY Id_F";
            else if(filtro == FiltrarPor.Cpf)
                query = "SELECT TOP(50) * FROM Funcionario WHERE CPF LIKE @cpf ORDER BY Id_F";
            else if(filtro == FiltrarPor.Id)
                query = "SELECT * FROM Funcionario WHERE Id_F LIKE @cpf ORDER BY Id_F";

            //if(filtro == FiltrarPor.Nome || filtro == FiltrarPor.Cpf)
            return obterFuncionarios(query, idNomeOuCpf);
        }

        public static DataTable BuscarFuncionario(FiltrarPor tipo, string nomeOuCpf, bool ativo, bool inativo, char sexoF, char sexoM, DateTime dataMinAd, DateTime dataMaxAd, bool semDatas, bool comDatas, float salarioMin, float salarioMax, string departamento)
        {
            nomeOuCpf = nomeOuCpf.Replace(".", "").Replace("-", "");
            string keyQuery = tipo == FiltrarPor.Nome ? "Nome" : "CPF";
            string complementQuery = "";
            string complementQuery2 = "";
            string complementQuery3 = "";
            //verificando a data
            if(semDatas && comDatas)
                complementQuery = "AND (DataAdmissao IS NULL OR DataAdmissao >= @dtMin AND DataAdmissao <= @dtMax) ";
            else if(comDatas)
                complementQuery = "AND (DataAdmissao >= @dtMin AND DataAdmissao <= @dtMax) ";
            else if(semDatas)
                complementQuery = "AND (DataAdmissao IS NULL) ";
            //verificando salario
            if(salarioMin == 0f)
                complementQuery2 = "Salario IS NULL OR";
            //verificando departamento
            if(departamento == "Sem Departamentos")
                complementQuery3 = "Id_Departamento is NULL OR";
            else if(departamento == "Todos Departamentos")
                departamento = "";
            else if(departamento == "Todos(Com ou Sem)")
            {
                complementQuery3 = "Id_Departamento is NULL OR";
                departamento = "";
            }

            string query =  "SELECT TOP(50) * FROM Funcionario WHERE "+keyQuery +" Like @nomeOuCpf "+ 
                            "AND (Ativo = @ativo or Ativo = @inativo) "+
                            "AND (Sexo = @sexoF or Sexo = @sexoM) "+
                            complementQuery+
                            "AND ("+complementQuery2+" Salario >= @salMix AND Salario <= @salMax) "+
                            "AND ("+complementQuery3+" Id_Departamento IN (SELECT Id_D FROM Departamento WHERE Nome Like @nomeDp)) "+
                            "ORDER BY Id_F";

            if(comDatas)
                return obterFuncionarios(query, "%" + nomeOuCpf + "%", ativo, !inativo, sexoF, sexoM, dataMinAd, dataMaxAd, salarioMin, salarioMax, "%"+departamento+"%");
            else
                return obterFuncionarios(query, "%" + nomeOuCpf + "%", ativo, !inativo, sexoF, sexoM, salarioMin, salarioMax, "%"+departamento+"%");
        }

        public static Funcionario BuscarFuncionarioPorId(int id)
        {
            //retorna Departamento Nullo por conta da propriedade ser de um tipo diferente do banco. 
            Funcionario funcionario = new DataAcessSqlCE().Consultar<Funcionario>("SELECT * FROM Funcionario WHERE Id_F = @id", id).FirstOrDefault();
            if(funcionario == null)
                throw new Exception("Este Id não pertence a nenhum funcionario!");

            Departamento departamento = new DataAcessSqlCE().Consultar<Departamento>("SELECT * FROM Departamento WHERE Id_D in (SELECT Id_Departamento FROM Funcionario WHERE Id_F = @idfunc)", id).FirstOrDefault();//subquerie,Busca o departamento do Funcionario de Id X
            if(departamento != null)
                funcionario.Departamento = departamento;
            return funcionario;
        }

        public static void BuscarMaiorMenorSalarioEData(out float maiorValorSalarial, out float menorValorSalarial, out DateTime dataMax, out DateTime dataMin)
        {
            DataTable dt = new DataAcessSqlCE().Consultar("SELECT MAX(Salario) AS MaiorSalario,  MIN(Salario) As MenorSalario, MAX(DataAdmissao) AS MaiorData, MIN(DataAdmissao) AS MenorData FROM Funcionario");
            
            if(!string.IsNullOrEmpty(dt.Rows[0][0].ToString()))            
                maiorValorSalarial = Convert.ToSingle(dt.Rows[0]["MaiorSalario"]);
            else
                maiorValorSalarial = 100000;
            if(!string.IsNullOrEmpty(dt.Rows[0][1].ToString()))    
                menorValorSalarial = Convert.ToSingle(dt.Rows[0]["MenorSalario"]);
            else
                menorValorSalarial = 0;
            if(!string.IsNullOrEmpty(dt.Rows[0][2].ToString()))    
                dataMax = Convert.ToDateTime(dt.Rows[0]["MaiorData"]);
            else
                dataMax = DateTime.Now;
            if(!string.IsNullOrEmpty(dt.Rows[0][3].ToString()))  
                dataMin = Convert.ToDateTime(dt.Rows[0]["MenorData"]);
            else
                dataMin = new DateTime(1753, 1, 1);
            //}
            //else
            //{
            //    
            //    
            //    
            //    dataMin = new DateTime(1753, 1, 1);
            //}
        }

        private static DataTable obterFuncionarios(string query, params object[] valores)
        {
            DataTable funcionarios = new DataAcessSqlCE().Consultar(query, valores);
            //Adiciono uma coluna para adicionar o nome dos departamentos                
            funcionarios.Columns.Add("Nome Departamento", typeof(string));
            //Busco os departamentos para comparar
            List<Departamento> departamentos = Departamento.BuscarDepartamentos();
            //Pego o Id e adiciono o nome dos departamentos
            foreach(DataRow linha in funcionarios.Rows)
            {
                int idD;
                if(int.TryParse(linha["Id_Departamento"].ToString(), out idD))
                {
                    linha["Nome Departamento"] = (from d in departamentos
                                                  where d.Id_D == idD
                                                  select d.Nome).First();//linha["Nome"];linha["Nome Departamento"]
                }
            }

            funcionarios.Columns.Remove("Id_Departamento");

            //if(funcionarios.Rows.Count == 0)
            //    throw new Exception("Não possui nenhum funcionario cadastrado!");

            return funcionarios;
        }

        private bool cpfExiste(string CPF)
        {
            DataAcessSqlCE acessoBanco = new DataAcessSqlCE();
            int qntRegistros = (int)acessoBanco.ObterUnicoValor("SELECT COUNT('Id_F') FROM Funcionario WHERE CPF = @valor", CPF);

            if(qntRegistros > 0)
                return true;
            else
                return false;
        }
    }
}
