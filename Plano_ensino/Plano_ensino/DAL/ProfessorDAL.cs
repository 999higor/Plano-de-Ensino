using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plano_ensino.DAL
{
    class ProfessorDAL
    {
        //static string strConnection = @"Data Source=HIGOR\SQLEXPRESS;Initial Catalog=PlanoDeEnsino;Integrated Security=True;Pooling=False";

        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\higor\Documents\GitHub\Plano-de-Ensino\banco de dados\BD_PlanoEnsino.mdf';Integrated Security=True;Connect Timeout=30";

        public static int Inserir(string pnome, int crm)
        {
            //texto com o comando que sera executado
            string cmd = "Insert into Professor (nome ,IdProfessor) values (@nome ,@id)";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql
            sqlcmd.Parameters.AddWithValue("@nome", pnome);
            sqlcmd.Parameters.AddWithValue("@id", crm);

            try
            {
                conn.Open();    //abre a conexao com o banco
                res = sqlcmd.ExecuteNonQuery(); //executa o comando no banco de dados

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return res;
        }


        public static int Alterar(int pidProfessor, string pnome)
        {
            //texto com o comando que sera executado
            string cmd = "UPDATE Professor " +
                "SET Nome = @nome  WHERE IdProfessor = @IdProfessor";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql

            sqlcmd.Parameters.AddWithValue("@IdProfessor", pidProfessor);
            sqlcmd.Parameters.AddWithValue("@nome", pnome);


            try
            {
                conn.Open();    //abre a conexao com o banco
                res = sqlcmd.ExecuteNonQuery(); //executa o comando no banco de dados

            }
            catch (Exception)
            {

                //throw;
            }
            finally
            {
                conn.Close();
            }

            return res;
        }

        public static int Excluir(int pidProfessor)
        {
            //texto com o comando que sera executado
            string cmd = "DELETE FROM Professor WHERE IdProfessor = @IdProfessor";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql


            sqlcmd.Parameters.AddWithValue("@IdProfessor", pidProfessor);

            try
            {
                conn.Open();    //abre a conexao com o banco
                res = sqlcmd.ExecuteNonQuery(); //executa o comando no banco de dados

            }
            catch (Exception)
            {

                //throw;
            }
            finally
            {
                conn.Close();
            }

            return res;
        }

        public static DataSet atualizaTabela()
        {
            //texto com o comando sql que sera executado
            string cmd = "SELECT IdProfessor AS SIAPE, nome AS Nome " +
                            "FROM Professor";
                            //WHERE(nome = @texto)";

            //objeto que ira fazer a conexao
            SqlConnection conn = new SqlConnection(strConnection);
            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;

            DataSet dataSet = new DataSet();


            try
            {
                conn.Open();    //abre a conexao com o banco
                adapter.Fill(dataSet);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return dataSet;
        }

        public static DataSet Pesquisar(String texto)
        {
            //texto com o comando sql que sera executado
            string cmd = "SELECT IdProfessor AS SIAPE, nome AS Nome "+
                        " FROM Professor "+
                        " WHERE(nome LIKE @texto)";

            //objeto que ira fazer a conexao
            SqlConnection conn = new SqlConnection(strConnection);
            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            sqlcmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;

            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();    //abre a conexao com o banco
                adapter.Fill(dataSet);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return dataSet;
        }

        public static DataTable atualiza_combo()
        {
            //texto com o comando sql que sera executado
            string cmd = "Select * from Professor";

            //objeto que ira fazer a conexao
            SqlConnection conn = new SqlConnection(strConnection);
            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;

            DataTable dataSet = new DataTable();


            try
            {
                conn.Open();    //abre a conexao com o banco
                adapter.Fill(dataSet);



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return dataSet;
        }
    }
}
