using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Funcionarios.Others;
using Funcionarios.Persistence;
using System.Data;
namespace Funcionarios.Model
{
    class Departamento
    {
        //Properties & Fields
        public int Id_D { get; set; }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome =  System.Globalization.CultureInfo.GetCultureInfo("pt-BR").TextInfo.ToTitleCase(value.ToLower()); }
        }

        //Construct/Overload Construct
        public Departamento(int id, string nome)
        {
            Id_D = id;
            Nome = nome;
        }

        public Departamento(string nome)
        {
            Nome = nome;
        }

        public Departamento() { }

        //Methods
        public void Cadastrar()
        {
            if (this.Nome.Trim().Equals(string.Empty))
                throw new ExceptionNomeVazio("O Campo Nome não pode ser vazio"); //exceção explícita

            DataAcessSqlCE acessoBanco = new DataAcessSqlCE();

            if (nomeExiste(this.Nome.Trim()))
                throw new ExceptionRegistroExistente("Já Existe um Departamento com este nome");

            acessoBanco.Executar("INSERT INTO Departamento (Nome) VALUES", this.Nome);

        }

        public void SalvarAlteracoes()
        {
            if (this.Nome.Trim().Equals(string.Empty))
                throw new ExceptionNomeVazio("O Campo Nome não pode ser vazio"); //exceção explícita

            DataAcessSqlCE acessoBanco = new DataAcessSqlCE();

            if (nomeExiste(this.Nome))
                throw new ExceptionRegistroExistente("Já Existe um Departamento com este nome");

            acessoBanco.Executar("UPDATE Departamento SET Nome " +
                                 "WHERE Id_D = @id", this.Id_D,
                                                          this.Nome);
        }

        public void Excluir()
        {
            DataAcessSqlCE acessoBanco = new DataAcessSqlCE();
            acessoBanco.Executar("DELETE FROM Departamento WHERE Id_D = @id", this.Id_D);
        }                   
        
        /// <summary>
        /// Busca funcionarios por parte do nome ou nome completo
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="nomePorCompleto">Caso true, procura o funcionario pelo nome completo</param>
        /// <returns></returns>
        public static List<Departamento> BuscarDepartamentos(string nome = null, bool nomePorCompleto = false)
        {
            string valor = nomePorCompleto ? nome : "%"+nome+"%";
            List <Departamento> departamentos = new DataAcessSqlCE().Consultar<Departamento>("SELECT * FROM Departamento WHERE Nome LIKE @nome ORDER BY Id_D", valor);

            if (!nomePorCompleto && departamentos.Count == 0)
                throw new Exception("Não Existe nenhum departamento com esse Nome!");

            return departamentos;
        }

        public static Departamento BuscarDepartamentoPorId(int id)
        {
            Departamento departamento = new DataAcessSqlCE().Consultar<Departamento>("SELECT * FROM Departamento WHERE Id_D = @id", id).FirstOrDefault();

            if (departamento == null)
                throw new Exception("Não possui nenhum departamento cadastrado!");

            return departamento;
        }

        public static List<string> BuscarNomeTodosDepartamentos(params string[] itemsAdicionais)
        {
            List<string> nomesDepartamentos = new List<string>(itemsAdicionais);
            List<Departamento> departamentos = BuscarDepartamentos();

            foreach (Departamento dp in departamentos)
                nomesDepartamentos.Add(dp.Nome);

            //foreach(DataRow linha in departamentos.Rows)
            //    nomesDepartamentos.Add(linha["Nome"].ToString());

            return nomesDepartamentos;
        }
                
        private bool nomeExiste(string nomeDepartamento)
        {
            //verifica se ja existe o departamento
            try
            {
                DataAcessSqlCE acessoBanco = new DataAcessSqlCE();
                //int qtdRegistros = acessoBanco.VerificarSeExiste("Departamento", "Nome", nomeDepartamento);
                int qntRegistros = (int)acessoBanco.ObterUnicoValor("SELECT COUNT('Id_D') FROM Departamento WHERE Nome = @valor", nomeDepartamento);

                if (qntRegistros > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
        }
    }
}
