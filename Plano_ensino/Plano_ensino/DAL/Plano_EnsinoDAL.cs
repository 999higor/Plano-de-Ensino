using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plano_ensino.DAL
{
    class Plano_EnsinoDAL
    {
        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\higor\Documents\GitHub\Plano-de-Ensino\banco de dados\BD_PlanoEnsino.mdf';Integrated Security=True;Connect Timeout=30";

        public static int Inserir(int ano, int semestre, string colegiado, string integracao, string avaliacao,
            string ref_aprofundamento, string conteudo_programado, string cronograma, string recuperacao,
            string metodologia, int comp_curricular, string nome, string professor)
        {
            //texto com o comando que sera executado
            string cmd = "INSERT INTO PlanoEnsino (ano ,semestre_letivo, colegiado, possibilidade_integracao, avaliacao_curricular, referencias_aprofundamento, "+
                " conteudo_programado, cronograma, estrategia_recuperacao, metodologia, codigo_componente_curricular, nome, professores) "+
                " VALUES (@ano ,@semestre, @colegiado, @possibilidade_integracao, @avaliacao_curricular, @referencias_aprofundamento, "+
                " @conteudo_programado, @cronograma, @estrategia_recuperacao, @metodologia, @codigo_componente_curricular, @nome, @professores)";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql
            sqlcmd.Parameters.AddWithValue("@ano", ano);
            sqlcmd.Parameters.AddWithValue("@semestre", semestre);
            sqlcmd.Parameters.AddWithValue("@colegiado", colegiado);
            sqlcmd.Parameters.AddWithValue("@possibilidade_integracao", integracao);
            sqlcmd.Parameters.AddWithValue("@avaliacao_curricular", avaliacao);
            sqlcmd.Parameters.AddWithValue("@referencias_aprofundamento", ref_aprofundamento);
            sqlcmd.Parameters.AddWithValue("@conteudo_programado", conteudo_programado);
            sqlcmd.Parameters.AddWithValue("@cronograma", cronograma);
            sqlcmd.Parameters.AddWithValue("@estrategia_recuperacao", recuperacao);
            sqlcmd.Parameters.AddWithValue("@metodologia", metodologia);
            sqlcmd.Parameters.AddWithValue("@codigo_componente_curricular", comp_curricular);
            sqlcmd.Parameters.AddWithValue("@nome", nome);
            sqlcmd.Parameters.AddWithValue("@professores", professor);

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


        public static int Alterar(int idPlano, int ano, int semestre, string colegiado, string integracao, string avaliacao,
            string ref_aprofundamento, string conteudo_programado, string cronograma, string recuperacao,
            string metodologia, int comp_curricular, string nome, string professor)
        {
            //texto com o comando que sera executado
            string cmd = "UPDATE PlanoEnsino " +
                "SET ano = @ano, semestre_letivo = @semestre, colegiado = @colegiado, possibilidade_integracao = @possibilidade_integracao, avaliacao_curricular = @avaliacao_curricular, referencias_aprofundamento = @referencias_aprofundamento, " +
                " conteudo_programado = @conteudo_programado, cronograma = @cronograma, estrategia_recuperacao = @estrategia_recuperacao, metodologia = @metodologia, codigo_componente_curricular = @codigo_componente_curricular, @nome = nome, @professores = professores WHERE IdPlanoEnsino = @IdPlanoEnsino";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql

            sqlcmd.Parameters.AddWithValue("@IdPlanoEnsino", idPlano);
            sqlcmd.Parameters.AddWithValue("@ano", ano);
            sqlcmd.Parameters.AddWithValue("@semestre", semestre);
            sqlcmd.Parameters.AddWithValue("@colegiado", colegiado);
            sqlcmd.Parameters.AddWithValue("@possibilidade_integracao", integracao);
            sqlcmd.Parameters.AddWithValue("@avaliacao_curricular", avaliacao);
            sqlcmd.Parameters.AddWithValue("@referencias_aprofundamento", ref_aprofundamento);
            sqlcmd.Parameters.AddWithValue("@conteudo_programado", conteudo_programado);
            sqlcmd.Parameters.AddWithValue("@cronograma", cronograma);
            sqlcmd.Parameters.AddWithValue("@estrategia_recuperacao", recuperacao);
            sqlcmd.Parameters.AddWithValue("@metodologia", metodologia);
            sqlcmd.Parameters.AddWithValue("@codigo_componente_curricular", comp_curricular);
            sqlcmd.Parameters.AddWithValue("@nome", nome);
            sqlcmd.Parameters.AddWithValue("@professores", professor);


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

        public static int Excluir(int idPlano)
        {
            //texto com o comando que sera executado
            string cmd = "DELETE FROM PlanoEnsino WHERE IdPlanoEnsino = @IdPlanoEnsino";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql


            sqlcmd.Parameters.AddWithValue("@IdPlanoEnsino", idPlano);

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
            string cmd = "SELECT PlanoEnsino.IdPlanoEnsino AS ID, PlanoEnsino.ano AS Ano, PlanoEnsino.semestre_letivo AS Semestre, ComponenteCurricular.nome AS Componente, PlanoEnsino.colegiado AS Colegiado, " +
                " PlanoEnsino.possibilidade_integracao AS Integração, PlanoEnsino.avaliacao_curricular AS Avaliação, " +
                " PlanoEnsino.referencias_aprofundamento AS [Ref - Aprofundamento], PlanoEnsino.conteudo_programado AS Conteúdo, PlanoEnsino.cronograma AS Cronograma, " +
                " PlanoEnsino.estrategia_recuperacao AS Recuperação, PlanoEnsino.metodologia AS Metodologia, PlanoEnsino.codigo_componente_curricular AS[ID - CP], PlanoEnsino.nome AS Nome, PlanoEnsino.professores AS Professores " +
                " FROM PlanoEnsino INNER JOIN "+
                " ComponenteCurricular ON PlanoEnsino.codigo_componente_curricular = ComponenteCurricular.IdComponenteCurricular";
                


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
            string cmd = "SELECT PlanoEnsino.IdPlanoEnsino AS ID, PlanoEnsino.ano AS Ano, PlanoEnsino.semestre_letivo AS Semestre, ComponenteCurricular.nome AS Componente, PlanoEnsino.colegiado AS Colegiado, " +
                " PlanoEnsino.possibilidade_integracao AS Integração, PlanoEnsino.avaliacao_curricular AS Avaliação, " +
                " PlanoEnsino.referencias_aprofundamento AS [Ref - Aprofundamento], PlanoEnsino.conteudo_programado AS Conteúdo, PlanoEnsino.cronograma AS Cronograma, " +
                " PlanoEnsino.estrategia_recuperacao AS Recuperação, PlanoEnsino.metodologia AS Metodologia, PlanoEnsino.codigo_componente_curricular AS[ID - CP], PlanoEnsino.nome AS Nome, PlanoEnsino.professores AS Professores " +
                " FROM PlanoEnsino INNER JOIN " +
                " ComponenteCurricular ON PlanoEnsino.codigo_componente_curricular = ComponenteCurricular.IdComponenteCurricular " +
                " WHERE(PlanoEnsino.nome LIKE @texto)";

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
            string cmd = "Select * from ComponenteCurricular";

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

        public static DataTable atualiza_combo_Plano()
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
