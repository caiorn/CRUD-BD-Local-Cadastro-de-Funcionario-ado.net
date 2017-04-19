using System;
using System.Collections.Generic;
using System.Linq;

using System.Data.SqlServerCe;
using System.Data;
using System.Reflection;
//=========================================================
//classe generica resposavel por executar e buscar no banco
//=========================================================
namespace Funcionarios.Persistence
{
    public sealed class DataAcessSqlCE //no-inheritance
    {
        private string connectionstring; //"Data Source=localhost;Initial Catalog=db_Comercio; Trusted_Connection= Yes";
        private SqlCeConnection sqlconnection;
        private SqlCeCommand sqlcommand;

        public DataAcessSqlCE()
        {            
            connectionstring = ConfigSqlCE.connStr;
            sqlconnection = new SqlCeConnection(connectionstring);
            sqlcommand = new SqlCeCommand() { Connection = sqlconnection };
        }

        public void Executar(string query, params object[] valor)
        {
            sqlcommand.Parameters.Clear();

            string primeiraPalavra = query.Substring(0, query.IndexOf(' '));

            string[] parametros = null;
            string[] parametrosChave = new string[] { }; //p/ UPDATE valores das condiçoes Where Ex: @Id

            //Terá que retorna a query Montada e os parametros
            switch(primeiraPalavra)
            {
                case "INSERT"://"INSERT INTO tbl_Cliente (nome_cliente, sexo_cliente, email_cliente, cpf_cliente, telefone_cliente, celular_cliente) VALUES (";
                    Inserir(ref query, out parametros);
                    break;
                case "UPDATE": //UPDATE Departamento SET Nome, Local WHERE Nome = @nome or Id = @id
                    Alterar(ref query, out parametros, out parametrosChave);
                    for(int i = 0; i < parametrosChave.Length; i++)
                        sqlcommand.Parameters.AddWithValue(parametrosChave[i], valor[i]); //adicionado valores das chaves (CLÁUSULAS WHERE)
                    break;
                case "DELETE"://A query ja esta montada tera que retornar somente os parametros
                    Excluir(query, out parametros);//DELETE FROM Departamentos WHERE Id = @Id or Nome = @nome
                    break;
                case "SELECT":
                    throw new Exception("Ultilize o método Buscar() para consultas SELECT");
                default:
                    break;
            }
            //int t = parametrosChave.Length;
            sqlcommand.CommandText = query;
            //adicionando valores de inserção ou modificaçao nos parametros
            for(int i = 0; i < parametros.Length; i++)
            {
                var valorAtual = valor[i+parametrosChave.Length];
                //valorAtual is DateTime && ((DateTime)valorAtual) <= DateTime.MinValue ||
                if(valorAtual == null || valorAtual.ToString() == "")
                    sqlcommand.Parameters.AddWithValue(parametros[i], DBNull.Value);
                else
                    sqlcommand.Parameters.AddWithValue(parametros[i], valorAtual);
            }

            try
            {
                sqlconnection.Open();
                sqlcommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        private void Inserir(ref string query, out string[] parametros)
        {
            //("INSERT INTO Departamento (Nome) VALUES", txtNomeDepart.Text);
            query += " (";
            //separa as palavras, e armazena no array
            parametros = criarObterParametrosEntre(query, "(", ")");    //Ex Nome,Sexo,Salario

            //acrescenta os parametros na query
            foreach(string parametro in parametros)
                query += parametro + ", ";

            //removo a ultima virgula e acrescento a chave para fechar a query
            query = query.Remove(query.LastIndexOf(',')) + ')';
        }

        private void Excluir(string query, out string[] parametros)
        {
            //query = "DELETE FROM Departamento WHERE Id_D = @id or Nome = @nome";
            parametros = obterParametros(query);//Ex: @id,@nome
        }

        private void Alterar(ref string query, out string[] parametrosValores, out string[] parametrosChave)
        {
            parametrosChave = obterParametros(query);
            parametrosValores = criarObterParametrosEntre(query, "SET", "WHERE");

            int firstIndex = query.IndexOf("SET") + 3; // 1º palavra encontrada da query
            int lastIndex = query.IndexOf("WHERE");

            string parteInicio = query.Substring(0, firstIndex);
            string parteMeio = query.Substring(firstIndex, lastIndex - firstIndex);
            string parteFim = query.Substring(lastIndex);

            for(int i = 0; i < parametrosValores.Length; i++)
            {
                //pego o nome dos campos
                string nomeCampo = parametrosValores[i].Substring(4);
                //adicionar os campos com parametros
                parteMeio = parteMeio.Replace(nomeCampo, nomeCampo + " = " + parametrosValores[i]);

            }
            query = parteInicio + parteMeio + parteFim;
        }

        public DataTable Consultar(string query, params object[] valores)
        {            
            //query = "SELECT * FROM Departamentos WHere Estado = @Estado and Nome = @Nome";
            if(query.Contains('@'))
            {
                int qntArrobas = query.Count(c => c == '@');
                if(qntArrobas != valores.Length)
                    throw new Exception("A quantidade de Parametros é diferente da quantidade de valores passados no Método Consultar");
            }
            //query = SELECT * FROM Departametos
            sqlcommand.Parameters.Clear();
            sqlcommand.CommandText = query;
            string[] parametros = obterParametros(query);

            for(int i = 0; i < parametros.Length; i++)
                sqlcommand.Parameters.AddWithValue(parametros[i], valores[i]);

            SqlCeDataAdapter da = new SqlCeDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            try { da.Fill(dt); }
            catch { throw; }
            

            return dt;
        }

        public List<T> Consultar<T>(string query, params object[] valores) where T : class
        {
            if(query.Contains('@'))
            {
                int qntArrobas = query.Count(c => c == '@');
                if(qntArrobas != valores.Length)
                    throw new Exception("A quantidade de Parametros é diferente da quantidade de valores passados no Método Consultar");
            }
            //query = SELECT * FROM Departametos
            sqlcommand.Parameters.Clear();
            sqlcommand.CommandText = query;
            string[] parametros = obterParametros(query);

            for(int i = 0; i < parametros.Length; i++)
                sqlcommand.Parameters.AddWithValue(parametros[i], valores[i]);

            SqlCeDataAdapter da = new SqlCeDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<T> entidades = ConvertToList<T>(dt);
            return entidades;
        }



        public object ObterUnicoValor(string query, params object[] valoresChave)
        {
            sqlcommand.Parameters.Clear();
            sqlcommand.CommandText = query;
            string[] parametros = obterParametros(query);

            for(int i = 0; i < parametros.Length; i++)
                sqlcommand.Parameters.AddWithValue(parametros[i], valoresChave[i]);

            try
            {
                sqlconnection.Open();
                return sqlcommand.ExecuteScalar();
            }
            catch
            {
                throw;
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        //Este metodo retornara todos @parametros achados em uma query
        private string[] obterParametros(string query)
        {
            int qntArrobas = query.Count(c => c == '@');
            if(qntArrobas < 1)
                return new string[0];
            //cria um vetor para armazenar a posição dos @
            int[] indiceParametros = new int[qntArrobas];
            string[] nomeParametros = new string[qntArrobas];

            indiceParametros[0] = query.IndexOf('@'); //armazeno o indice do 1º
            //irá armazenando as posiçoes do @ a partir do ultimo
            for(int i = 1; i < qntArrobas; i++)
                indiceParametros[i] = query.IndexOf("@", indiceParametros[i - 1] + 1);

            //separa os parametro armazenando, removendo virgulas ou espaços que estiver a frente
            for(int i = 0; i < qntArrobas; i++)
            {
                int indiceArroba = indiceParametros[i];
                int indiceEspacoBranco = query.IndexOf(' ', indiceParametros[i]);
                int indiceVirgula   = query.IndexOf(',', indiceParametros[i]);


                if(indiceVirgula != -1  && indiceEspacoBranco > indiceVirgula)
                    nomeParametros[i] = query.Substring(indiceArroba, (indiceVirgula - indiceArroba));
                else if(indiceEspacoBranco != -1)
                    nomeParametros[i] = query.Substring(indiceArroba, (indiceEspacoBranco - indiceArroba));
                else if(indiceVirgula != -1)
                    nomeParametros[i] = query.Substring(indiceArroba, (indiceVirgula - indiceArroba));
                else
                    nomeParametros[i] = query.Substring(indiceArroba);

                nomeParametros[i] = nomeParametros[i].Replace("%", "").Replace(")", "").Replace("'", "");
            }
            return nomeParametros;
        }

        //Desmonta a frase de uma query e retorna as palavras(Campos) como @parametros
        private string[] criarObterParametrosEntre(string frase, string palavraInicial, string palavraFinal)
        {

            int firstIndex = frase.IndexOf(palavraInicial) + palavraInicial.Length; // 1º palavra encontrada da query
            int lastIndex = frase.IndexOf(palavraFinal);

            string[] parametros = frase.Substring(firstIndex, lastIndex - firstIndex).Replace(" ", "").Split(',');
            //Ex output: Nome,Sexo,Salario

            for(int i = 0; i < parametros.Length; i++)
                parametros[i] = "@p"+i.ToString("D2")+ parametros[i];

            return parametros;
            //Ex: @p0Nome,@p1Sexo,@p2Salario
        }

        //Converte um DataTable e em uma lista Generica(IMPORTANTE: As classes terão que ter os mesmo nomes dos campos da tabela)
        private List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName)
                    .ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name))
                    {
                        System.Reflection.PropertyInfo pI = objT.GetType().GetProperty(pro.Name);
                        var t = Nullable.GetUnderlyingType(pI.PropertyType) ?? pI.PropertyType;
                        pro.SetValue(objT, (row[pro.Name] == DBNull.Value) ? null : Convert.ChangeType(row[pro.Name], t));
                        //if(Nullable.GetUnderlyingType(pro.PropertyType) != null)
                        //    pro.SetValue(objT, (row[pro.Name] == DBNull.Value) ? null : Convert.ChangeType(row[pro.Name], Type.GetType(Nullable.GetUnderlyingType(pI.PropertyType).ToString()), null));
                        //else
                        //    pro.SetValue(objT, (row[pro.Name] == DBNull.Value) ? null : Convert.ChangeType(row[pro.Name], pI.PropertyType));                        

                    }
                }
                return objT;
            }).ToList();
        }
        
       /*public static DataTable ConvertToDataTable<T>(this List<T> list)
        {
            DataTable dt = new DataTable();
            if (list.Count > 0)
            {
                Type listType = list.ElementAt(0).GetType();
                //Pegando o elemento da propriedade e adicionando a coluna do DataTable
                PropertyInfo[] properties = listType.GetProperties();
                foreach (PropertyInfo property in properties)
                    dt.Columns.Add(new DataColumn() { ColumnName = property.Name });
                foreach (object item in list)
                {
                    DataRow dr = dt.NewRow();
                    foreach (DataColumn col in dt.Columns)
                        dr[col] = listType.GetProperty(col.ColumnName).GetValue(item, null);
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }*/
    }
}