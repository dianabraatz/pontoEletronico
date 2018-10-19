using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.Model;

namespace Coprel.DAO
{
    class FuncionarioDAO
    {

        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Administrador\Desktop\bdponto.mdf';Integrated Security=True;Connect Timeout=30";

        public Boolean verificaLogin(Funcionario f)
        {
            String sql = "SELECT * FROM funcionario WHERE numRegistro=@numRegistro AND senha=@senha;";
            bool result;

            //teste
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@numRegistro", f.GetNumeroRegistro());
            sqlcmd.Parameters.AddWithValue("@senha", f.GetSenha());

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

        public int VerificaNivelAcesso(Funcionario f)
        {
            string sql = "select f.nivelAcesso FROM funcao f JOIN funcionario func ON f.codFuncao = func.codFuncao WHERE func.numRegistro = @numRegistro AND func.senha = @senha;";
            int nivelAcesso = 0;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@numRegistro", f.GetNumeroRegistro());
            sqlcmd.Parameters.AddWithValue("@senha", f.GetSenha());

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

        public int CadastraFuncionario(Funcionario f)
        {
            String sql = "INSERT INTO funcionario ([numRegistro], [senha], [dataNascimento], [nome], [rg], [cpf], [cnh], [dataAdmissao], [ctps], [codFuncao], [codSetor]) VALUES " +
                                                 "(@numRegistro, @senha, @DataNascimento, @Nome, @RG, @CPF, @CNH, @DataAdmissao, @CTPS , @CodFuncao, @CodSetor)";
            int result;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@numRegistro", f.GetNumeroRegistro());
            sqlcmd.Parameters.AddWithValue("@senha", f.GetSenha());
            sqlcmd.Parameters.AddWithValue("@DataNascimento", f.GetDataNascimento());
            sqlcmd.Parameters.AddWithValue("@Nome", f.GetNome());
            sqlcmd.Parameters.AddWithValue("@RG", f.GetRG());
            sqlcmd.Parameters.AddWithValue("@CPF", f.GetCPF());
            sqlcmd.Parameters.AddWithValue("@CNH", f.GetCNH());
            sqlcmd.Parameters.AddWithValue("@DataAdmissao", f.GetDataAdmissao());
            sqlcmd.Parameters.AddWithValue("@CTPS", f.GetCTPS());
            sqlcmd.Parameters.AddWithValue("@CodSetor", f.GetCodSetor());
            sqlcmd.Parameters.AddWithValue("@CodFuncao", f.GetCodFuncao());


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

        public static DataTable PreencheCBFuncao()
        {
            string sql = "SELECT codFuncao, nome FROM funcao ORDER BY nome ASC;";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                reader = sqlcmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static DataTable PreencheCBSetor()
        {
            string sql = "SELECT codSetor, nome from setor ORDER BY nome ASC;";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                reader = sqlcmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        public static DataSet PreencheTabela()
        {
            string sql = "SELECT f.numRegistro as 'Numero de Registro', f.nome as 'Nome do Funcionario', s.nome as Setor, fu.nome as Função, f.cpf as CPF, f.dataNascimento AS 'Data de Nascimento' " +
                             "FROM funcionario f JOIN setor s ON f.codSetor = s.codSetor JOIN funcao fu ON f.codFuncao = fu.codFuncao;";

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

        public static DataSet ExecutaFiltro(string sql, string valor)
        {
            MessageBox.Show(sql);
            MessageBox.Show(valor);

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

        public List<Funcionario> PreencheCampos(int numeroRegistro)
        {
            string sql = "SELECT * FROM funcionario WHERE numREgistro = @registro;";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            List<Funcionario> lista = new List<Funcionario>();

            sqlcmd.Parameters.AddWithValue("@registro", numeroRegistro);

            try
            {
                conn.Open();
                SqlDataReader result = sqlcmd.ExecuteReader();

                while (result.Read())
                {
                    Funcionario f = new Funcionario();
                    f.SetNumeroRegistro(Convert.ToInt32(result["numRegistro"]));
                    f.SetNome(Convert.ToString(result["nome"]));
                    f.SetCPF(Convert.ToString(result["cpf"]));
                    f.SetCNH(Convert.ToString(result["cnh"]));
                    f.SetCodFuncao(Convert.ToInt32(result["codFuncao"]));
                    f.SetCodSetor(Convert.ToInt32(result["codSetor"]));
                    f.SetCTPS(Convert.ToString(result["ctps"]));
                    f.SetDataAdmissao(Convert.ToDateTime(result["dataAdmissao"]));
                    f.SetDataNascimento(Convert.ToDateTime(result["dataNascimento"]));
                    f.SetRG(Convert.ToString(result["rg"]));

                    lista.Add(f);
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
            return lista;
        
        }
    }
}


