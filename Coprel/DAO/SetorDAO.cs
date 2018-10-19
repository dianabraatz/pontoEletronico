using Coprel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coprel.DAO
{
    class SetorDAO
    {

        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Charlan\Desktop\bdponto.mdf';Integrated Security=True;Connect Timeout=30";

        public int CadastraSetor(Setor s)
        {
            String sql = "INSERT INTO setor ([codSetor], [nome]) VALUES (@codSetor, @nome)";
            int result;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@codSetor", s.GetCodSetor());
            sqlcmd.Parameters.AddWithValue("@nome", s.GetNome());           


            try
            {
                conn.Open();

                //verifica se possui algum resultado na consulta
                result = sqlcmd.ExecuteNonQuery();
                MessageBox.Show("" + result);
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

        public static DataSet PreencheTabelaSetor()
        {
            string sql = "SELECT s.codSetor as 'Código do Setor', s.nome as 'Nome do Setor' FROM setor s;";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

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

        public static DataSet ExecutaFiltroSetor(string sql, string valor)
        {
            //MessageBox.Show(sql);
            //MessageBox.Show(valor);

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@valor", "%" + valor + "%");

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;

            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
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
