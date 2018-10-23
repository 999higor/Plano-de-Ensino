using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plano_ensino.DAL
{
    class Prof_PlanoEnsinoDAL
    {
        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\higor\Documents\GitHub\Plano-de-Ensino\banco de dados\BD_PlanoEnsino.mdf';Integrated Security=True;Connect Timeout=30";

        public static int Inserir(int idProf, int idPlano)
        {
            //texto com o comando que sera executado
            string cmd = "Insert into PlanoEnsino_Professor (IdProfessor ,IdPlanoEnsino) values (@idProf ,@idPlano)";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql
            sqlcmd.Parameters.AddWithValue("@idProf", idProf);
            sqlcmd.Parameters.AddWithValue("@idPlano", idPlano);

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


        public static int Alterar(int IdProfessor, int IdPlanoEnsino)
        {
            //texto com o comando que sera executado
            string cmd = "UPDATE PlanoEnsino_Professor " +
                "SET IdProfessor = @IdProf, IdPlanoEnsino = @IdPlano  WHERE IdProfessor = @IdProfessor AND IdPlanoEnsino = @IdPlanoEnsino";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql

            sqlcmd.Parameters.AddWithValue("@IdProfessor", IdProfessor);
            sqlcmd.Parameters.AddWithValue("@IdPlanoEnsino", IdPlanoEnsino);


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

        public static int Excluir(int IdProfessor, int IdPlanoEnsino)
        {
            //texto com o comando que sera executado
            string cmd = "DELETE FROM PlanoEnsino_Professor WHERE IdProfessor = @IdProfessor AND IdPlanoEnsino = @IdPlanoEnsino";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql


            sqlcmd.Parameters.AddWithValue("@IdProfessor", IdProfessor);
            sqlcmd.Parameters.AddWithValue("@IdPlanoEnsino", IdPlanoEnsino);

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
            string cmd = " SELECT Professor.nome AS Professor, PlanoEnsino_Professor.IdProfessor AS CRM, " +
                        " PlanoEnsino_Professor.IdPlanoEnsino AS [ID - Plano Ensino], ComponenteCurricular.nome AS [Componente Currícular], PlanoEnsino.ano AS Ano " +
                        " FROM PlanoEnsino INNER JOIN " +
                        " PlanoEnsino_Professor ON PlanoEnsino.IdPlanoEnsino = PlanoEnsino_Professor.IdPlanoEnsino INNER JOIN " +
                        " Professor ON PlanoEnsino_Professor.IdProfessor = Professor.IdProfessor INNER JOIN " +
                        " ComponenteCurricular ON PlanoEnsino.codigo_componente_curricular = ComponenteCurricular.IdComponenteCurricular ";
                           // WHERE(Professor.nome = @texto) ";

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
            string cmd = " SELECT Professor.nome AS Professor, PlanoEnsino_Professor.IdProfessor AS CRM, " +
                        " PlanoEnsino_Professor.IdPlanoEnsino AS [ID - Plano Ensino], ComponenteCurricular.nome AS [Componente Currícular], PlanoEnsino.ano AS Ano " +
                        " FROM PlanoEnsino INNER JOIN " +
                        " PlanoEnsino_Professor ON PlanoEnsino.IdPlanoEnsino = PlanoEnsino_Professor.IdPlanoEnsino INNER JOIN " +
                        " Professor ON PlanoEnsino_Professor.IdProfessor = Professor.IdProfessor INNER JOIN " +
                        " ComponenteCurricular ON PlanoEnsino.codigo_componente_curricular = ComponenteCurricular.IdComponenteCurricular "+
                        " WHERE(Professor.nome = @texto) ";

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

        public static DataTable comboProfessor()
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

        public static DataTable comboPlanoEnsino()
        {
            //texto com o comando sql que sera executado
            string cmd = "Select * from PlanoEnsino";

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

