﻿using System;
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
            string metodologia, int comp_curricular)
        {
            //texto com o comando que sera executado
            string cmd = "INSERT INTO PlanoEnsino (ano ,semestre_letivo, colegiado, possibilidade_integracao, avaliacao_curricular, referencias_aprofundamento, "+
                " conteudo_programado, cronograma, estrategia_recuperacao, metodologia, codigo_componente_curricular) "+
                " VALUES (@ano ,@semestre, @colegiado, @possibilidade_integracao, @avaliacao_curricular, @referencias_aprofundamento, "+
                " @conteudo_programado, @cronograma, @estrategia_recuperacao, @metodologia, @codigo_componente_curricular)";
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
            string metodologia, int comp_curricular)
        {
            //texto com o comando que sera executado
            string cmd = "UPDATE PlanoEnsino " +
                "SET ano = @ano, semestre_letivo = @semestre, colegiado = @colegiado, possibilidade_integracao = @possibilidade_integracao, avaliacao_curricular = @avaliacao_curricular, referencias_aprofundamento = @referencias_aprofundamento, " +
                " conteudo_programado = @conteudo_programado, cronograma = @cronograma, estrategia_recuperacao = @estrategia_recuperacao, metodologia = @metodologia, codigo_componente_curricular = @codigo_componente_curricular WHERE IdPlanoEnsino = @IdPlanoEnsino";
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
            string cmd = "SELECT IdPlanoEnsino AS ID, ano AS Ano, semestre_letivo AS Semestre, colegiado AS Colegiado, possibilidade_integracao AS Integração, avaliacao_curricular AS Avaliação, " +
                " referencias_aprofundamento AS [Ref-Aprofundamento], conteudo_programado AS Conteúdo, cronograma AS Cronograma, estrategia_recuperacao AS Recuperação, metodologia AS Metodologia, codigo_componente_curricular AS[ID - CP] " +
                " FROM PlanoEnsino";
                


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
            string cmd = "SELECT IdPlanoEnsino AS ID, ano AS Ano, semestre_letivo AS Semestre, colegiado AS Colegiado, possibilidade_integracao AS Integração, avaliacao_curricular AS Avaliação, " +
                " referencias_aprofundamento AS [Ref-Aprofundamento], conteudo_programado AS Conteúdo, cronograma AS Cronograma, estrategia_recuperacao AS Recuperação, metodologia AS Metodologia, codigo_componente_curricular AS[ID - CP] " +
                " FROM PlanoEnsino " +
                " WHERE(ano = @texto)";

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
    }
}
