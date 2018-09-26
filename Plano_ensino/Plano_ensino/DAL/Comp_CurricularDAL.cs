using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plano_ensino.DAL
{
    class Comp_CurricularDAL
    {
        static string strConnection = @"Data Source=HIGOR\SQLEXPRESS;Initial Catalog=PlanoDeEnsino;Integrated Security=True;Pooling=False";

        public static int Inserir(string nome, int semestre, string objetivo, string modalidade_oferta, string ementa, string referencias_basicas, string referencias_complementares, int hora_aula_distancia, int hora_aula_presencial, int hora_relogio_distancia, int hora_relogio_presencial, int codigo_curso)
        {
            //texto com o comando que sera executado
            string cmd = "Insert into ComponenteCurricular (nome , semestre, objetivo, modalidade_oferta, ementa, referencias_basicas, referencias_complementares, hora_aula_distancia, hora_aula_presencial, hora_relogio_distancia, hora_relogio_presencial, codigo_curso)  "+
                " values (@nome, @semestre, @objetivo, @modalidade_oferta, @ementa, @referencias_basicas, @referencias_complementares, @hora_aula_distancia, @hora_aula_presencial, @hora_relogio_distancia, @hora_relogio_presencial, @codigo_curso)";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql
            sqlcmd.Parameters.AddWithValue("@nome", nome);
            sqlcmd.Parameters.AddWithValue("@semestre", semestre);
            sqlcmd.Parameters.AddWithValue("@objetivo", objetivo);
            sqlcmd.Parameters.AddWithValue("@modalidade_oferta", modalidade_oferta);
            sqlcmd.Parameters.AddWithValue("@ementa", ementa);
            sqlcmd.Parameters.AddWithValue("@referencias_basicas", referencias_basicas);
            sqlcmd.Parameters.AddWithValue("@referencias_complementares", referencias_complementares);
            sqlcmd.Parameters.AddWithValue("@hora_aula_distancia", hora_aula_distancia);
            sqlcmd.Parameters.AddWithValue("@hora_aula_presencial", hora_aula_presencial);
            sqlcmd.Parameters.AddWithValue("@hora_relogio_distancia", hora_relogio_distancia);
            sqlcmd.Parameters.AddWithValue("@hora_relogio_presencial", hora_relogio_presencial);
            sqlcmd.Parameters.AddWithValue("@codigo_curso", codigo_curso);

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


        public static int Alterar(int idcomponentecurricular, string nome, int semestre, string objetivo, string modalidade_oferta, string ementa, string referencias_basicas, string referencias_complementares, int hora_aula_distancia, int hora_aula_presencial, int hora_relogio_distancia, int hora_relogio_presencial, int codigo_curso)
        {
            //texto com o comando que sera executado
            string cmd = "UPDATE ComponenteCurricular " +
                "SET nome = @nome, semestre = @semestre, objetivo = @objetivo, modalidade_oferta = @modalidade_oferta, "+
                " ementa = @ementa, referencias_basicas = @referencias_basicas, referencias_complementares = @referencias_complementares, "+
                "  hora_aula_distancia = @hora_aula_distancia, hora_aula_presencial = @hora_aula_presencial, hora_relogio_distancia = @hora_relogio_distancia, "+
                "  hora_relogio_presencial = @hora_relogio_presencial, codigo_curso = @codigo_curso WHERE IdComponenteCurricular = @idcomponentecurricular";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql
            sqlcmd.Parameters.AddWithValue("@idcomponentecurricular", idcomponentecurricular);
            sqlcmd.Parameters.AddWithValue("@nome", nome);
            sqlcmd.Parameters.AddWithValue("@semestre", semestre);
            sqlcmd.Parameters.AddWithValue("@objetivo", objetivo);
            sqlcmd.Parameters.AddWithValue("@modalidade_oferta", modalidade_oferta);
            sqlcmd.Parameters.AddWithValue("@ementa", ementa);
            sqlcmd.Parameters.AddWithValue("@referencias_basicas", referencias_basicas);
            sqlcmd.Parameters.AddWithValue("@referencias_complementares", referencias_complementares);
            sqlcmd.Parameters.AddWithValue("@hora_aula_distancia", hora_aula_distancia);
            sqlcmd.Parameters.AddWithValue("@hora_aula_presencial", hora_aula_presencial);
            sqlcmd.Parameters.AddWithValue("@hora_relogio_distancia", hora_relogio_distancia);
            sqlcmd.Parameters.AddWithValue("@hora_relogio_presencial", hora_relogio_presencial);
            sqlcmd.Parameters.AddWithValue("@codigo_curso", codigo_curso);


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

        public static int Excluir(int IdComponenteCurricular)
        {
            //texto com o comando que sera executado
            string cmd = "DELETE FROM ComponenteCurricular WHERE IdComponenteCurricular = @idcomponentecurricular";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql


            sqlcmd.Parameters.AddWithValue("@IdComponenteCurricular", IdComponenteCurricular);

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

        public static DataSet atualizaTabela()
        {
            //texto com o comando sql que sera executado
            string cmd = "Select * from ComponenteCurricular";

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
            string cmd = "Select * from ComponenteCurricular WHERE nome LIKE @texto";

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
            string cmd = "Select * from Curso";

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
