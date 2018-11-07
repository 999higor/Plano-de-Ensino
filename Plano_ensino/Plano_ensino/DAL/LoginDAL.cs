using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plano_ensino.DAL
{
    class LoginDAL
    {
        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\higor\Documents\GitHub\Plano-de-Ensino\banco de dados\BD_PlanoEnsino.mdf';Integrated Security=True;Connect Timeout=30";

        public static int Login(string login, string senha)
        {
            //texto com o comando que sera executado
            string cmd = "SELECT * FROM Professor WHERE IdProfessor = @login";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(strConnection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql
            sqlcmd.Parameters.AddWithValue("@login", login);
            sqlcmd.Parameters.AddWithValue("@senha", senha);

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
    }
}
