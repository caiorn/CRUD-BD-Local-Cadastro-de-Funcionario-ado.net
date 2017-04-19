using System;
using System.IO;
using System.Data.SqlServerCe;
//==========================================================
//classe responsavel para criaçao do banco de dados e pastas
//===========================================================
namespace Funcionarios.Persistence
{
    class ConfigSqlCE
    {
        //diretorios da pastas da dos dados
        private string pastaDados { get; set; }
        public  static string pastaFotos { get; private set; }
        //base de dados
        private string nomeBD { get; set; }
        private string senhaBD { get; set; }
        public static string connStr { get; private set; }

        public ConfigSqlCE()
        {
            pastaDados = Environment.CurrentDirectory + @"\DataBase\";
            pastaFotos = pastaDados + @"Photos\";

            nomeBD = "dados.sdf";
            senhaBD = "1234";

            //Definição da conection string
            connStr = "Data Source=" + pastaDados + nomeBD + ";Password=" + senhaBD;

            criarPastas();
            if(criarBanco())
                executarQueries();
        }
        
        private void criarPastas()
        {
            //se nao existir, cria pasta de dados
            if(!Directory.Exists(pastaDados))
                Directory.CreateDirectory(pastaDados);

            //se nao existir, criar a pasta de fotos
            if(!Directory.Exists(pastaFotos))
                Directory.CreateDirectory(pastaFotos);
        }

        private bool criarBanco()
        {
            //se nao existir, cria o banco de dados
            if(!File.Exists(pastaDados + nomeBD))
            {
                SqlCeEngine engine = new SqlCeEngine(connStr);
                engine.CreateDatabase();
                engine.Dispose();
                return true;
            }
            else
                return false;
        }

        private void executarQueries()
        {
            SqlCeConnection conn = new SqlCeConnection(connStr); ;

            try
            {
                conn.Open();
                using(SqlCeCommand cmd = conn.CreateCommand())
                {
                    criarTabelas(cmd);
                    inserirDepartamentos(cmd);
                    inserirFuncionarios(cmd);
                }
            }
            catch { throw; }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void criarTabelas(SqlCeCommand sqlcommand)
        {
            //Tabelas
            sqlcommand.CommandText = 
               @"CREATE TABLE Departamento(
                   Id_D            INT CONSTRAINT pk_Id_Departamento PRIMARY KEY IDENTITY,
                   Nome            NVARCHAR(30)
                )";
            sqlcommand.ExecuteNonQuery();
            sqlcommand.CommandText =
                @"CREATE TABLE Funcionario (
                   Id_F            INT CONSTRAINT pk_Id_Funcionario PRIMARY KEY IDENTITY,
                   Nome            NVARCHAR(50) NOT NULL,
                   CPF             NVARCHAR(11),
                   DataNascimento  DATETIME,
                   Sexo            NCHAR(1),
                   Celular         NCHAR(11),                   
                   Email           NVARCHAR(50),
                   Foto            NVARCHAR(25),
                   DataAdmissao    DATETIME,
                   Id_Departamento INT CONSTRAINT fk_Id_Departamento REFERENCES Departamento(Id_D) ON DELETE CASCADE ON UPDATE CASCADE,
                   Salario         MONEY,
                   Ativo           BIT
                )";
            sqlcommand.ExecuteNonQuery();

        }

        private void inserirDepartamentos(SqlCeCommand sqlcommand)
        {
            //Inserts
            string[] departamentos = new string[] 
            {
                "Financeiro",
                "Jurídico",
                "Marketing",
                "Comercial",
                "Compras",
                "Administrativo",
                "TI",
                "Gerência",
                "Diretoria",
                "Presidência",
            };

            foreach(string departamento in departamentos)
            {
                sqlcommand.CommandText = string.Format("INSERT INTO Departamento (Nome) VALUES ('{0}');", departamento);
                sqlcommand.ExecuteNonQuery();
            }

        }

        private void inserirFuncionarios(SqlCeCommand sqlcommand)
        {
            string x = @"INSERT INTO Funcionario (Nome, CPF, DataNascimento, Sexo, Celular, Foto, Email, DataAdmissao, Id_Departamento, Salario,Ativo) VALUES 
            ('Test', '44260443836', '1995-05-25', 'M', '11954573510', null, 'exemple@gmail.com', '2017-03-22', 1, 1200, 1)";
        }
    }
}
