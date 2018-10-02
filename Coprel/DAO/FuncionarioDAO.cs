using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coprel.DAO
{
    class FuncionarioDAO
    {

        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Charlan\source\repos\vs2017-coprel\bdponto.mdf';Integrated Security=True;Connect Timeout=30";

        public Boolean verificaLogin(int numRegistro, string senha)
        {
            String sql = "SELECT * FROM funcionario WHERE numRegistro=@numRegistro AND senha=@senha;";
            bool result;

            //teste
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@numRegistro", numRegistro);
            sqlcmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                conn.Open();
                SqlDataReader rows = sqlcmd.ExecuteReader();

                //verifica se possui algum resultado na consulta
                result = rows.Read();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int VerificaNivelAcesso(int numRegistro, string senha)
        {
            string sql = "select f.nivelAcesso FROM funcao f JOIN funcionario func ON f.codFuncao = func.codFuncao WHERE func.numRegistro = @numRegistro AND func.senha = @senha;";
            int nivelAcesso = 0;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@numRegistro", numRegistro);
            sqlcmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                conn.Open();
                SqlDataReader result = sqlcmd.ExecuteReader();

                while (result.Read())
                {
                    nivelAcesso = Convert.ToInt32(result["nivelAcesso"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return nivelAcesso;
        }
    }
}


