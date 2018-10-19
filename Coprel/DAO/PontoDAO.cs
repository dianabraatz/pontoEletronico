using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.Model;

namespace Coprel.DAO
{
    class PontoDAO
    {
        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Administrador\Desktop\bdponto.mdf';Integrated Security=True;Connect Timeout=30";

        public int VerificaPonto(int numRegistro)
        {
            string sql = "SELECT COUNT(dh_ponto1) as p1, COUNT(dh_ponto2) as p2 ,COUNT(dh_ponto3)as p3,COUNT(dh_ponto4) as p4 from ponto WHERE (CONVERT(date, dh_ponto1)) = CONVERT(date, CURRENT_TIMESTAMP) and numRegistro = @numRegistro;";
            int resultado;
            int ponto1 = 0, ponto2 = 0, ponto3 = 0, ponto4 = 0;


            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@numRegistro", numRegistro);

            try
            {
                conn.Open();
                SqlDataReader result = sqlcmd.ExecuteReader();

                while (result.Read())
                {
                    ponto1 = Convert.ToInt32(result["p1"]);
                    ponto2 = Convert.ToInt32(result["p2"]);
                    ponto3 = Convert.ToInt32(result["p3"]);
                    ponto4 = Convert.ToInt32(result["p4"]);
                }

                if (ponto1 == 0)
                {
                    resultado = 1; //ponto 1 vazio, cria um novo
                }
                else if (ponto2 == 0)
                {
                    resultado = 2; //ponto 2 vazio, add um ponto 2
                }
                else if (ponto3 == 0)
                {
                    resultado = 3; //ponto 3 vazio, add um ponto 3
                }
                else if (ponto4 == 0)
                {
                    resultado = 4; //ponto 4 vazio, add um ponto 4
                }
                else if (ponto4 == 1)
                {
                    resultado = 5;
                }
                else
                {
                    resultado = 6;

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
            return resultado;
        }

        public int CadastrarPonto(int numRegistro, string sql)
        {
            int result = 0;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@numRegistro", numRegistro);

            try
            {
                conn.Open();
                result = sqlcmd.ExecuteNonQuery();
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

        public List<String> ConfirmaPonto(int numRegistro)
        {
            string sql = "SELECT CONVERT(varchar(10), p.dh_ponto1, 105) as data, CONVERT(varchar(8), current_timestamp, 108) as hora, f.nome, p.numRegistro FROM ponto p JOIN funcionario f ON p.numRegistro = f.numRegistro " +
                                                       "WHERE CONVERT(date, dh_ponto1) = CONVERT(date, CURRENT_TIMESTAMP) AND p.numRegistro = @numRegistro;";
            List<String> lista = new List<String>();

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@numRegistro", numRegistro);

            try
            {
                conn.Open();
                SqlDataReader result = sqlcmd.ExecuteReader();

                while (result.Read())
                {
                    lista.Add(Convert.ToString(result["data"]));
                    lista.Add(Convert.ToString(result["hora"])); 
                    lista.Add(Convert.ToString(result["nome"]));
                    lista.Add(Convert.ToString(result["numRegistro"]));
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

        /*
         *          VERIFICA PONTO VELHO
         * 
        public int VerificaPonto(int numRegistro)
        {
            //verifica se possui ponto cadastrado no dia
            string sql = "SELECT * FROM ponto WHERE (CONVERT(date , dh_ponto1)) = (CONVERT(date, CURRENT_TIMESTAMP)) AND numregistro = @numRegistro;";
            bool result;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

           
             * 
             *  ****** VERIFICAÇÃO DO PONTO *******

                //verificação 1 == se verdadeiro testa v2 --> se falso irá criar um novo ponto
                SELECT * FROM ponto WHERE (CONVERT(date , dh_ponto1)) = (CONVERT(date, CURRENT_TIMESTAMP)) AND numregistro = 10000;

                //verificação 2 == se verdadeiro testa v3 --> se falso atualiza o ponto  insere no ponto 2
                SELECT * FROM ponto WHERE (CONVERT(date, dh_ponto2)) = CONVERT(date, CURRENT_TIMESTAMP) AND dh_ponto1 is not null and dh_ponto2 is null AND numregistro = 10000;

                //verificação 3 == se verdadeiro testa v4 --> se falso atualiza o ponto / insere no ponto 3
                SELECT * FROM ponto WHERE (CONVERT(date, dh_ponto2)) = CONVERT(date, CURRENT_TIMESTAMP) AND dh_ponto1 is not null and dh_ponto2 is null and dh_ponto3 is null AND numregistro = 10000

                //verificacao 4 == se verdadeiro --> não é possivel adicionar mais pontos(limete excedido) --> se falso insere no ponto 4
                SELECT * FROM ponto WHERE (CONVERT(date, dh_ponto2)) = CONVERT(date, CURRENT_TIMESTAMP) AND dh_ponto1 is not null and dh_ponto2 is null and dh_ponto3 is null and dh_ponto4 is null AND numregistro = 10000

            try
            {
                sqlcmd.Parameters.AddWithValue("@numRegistro", numRegistro);

                conn.Open();
                SqlDataReader rows = sqlcmd.ExecuteReader();

                //verifica se possui algum resultado na consulta
                result = rows.Read();
                rows.Close();

                if (!result)
                {
                    return 1;
                }

                else
                {
                    sql = "SELECT * FROM ponto WHERE (CONVERT(date, dh_ponto1)) = CONVERT(date, CURRENT_TIMESTAMP) AND dh_ponto1 is not null and dh_ponto2 is null AND numregistro = @numRegistro;";

                    conn = new SqlConnection(strConnection);
                    sqlcmd = new SqlCommand(sql, conn);
                    //conn.Open();

                    //                    sqlcmd.Parameters.AddWithValue("@numRegistro", numRegistro);
                    rows = sqlcmd.ExecuteReader();
                    result = rows.Read();
                    rows.Close();
                    MessageBox.Show("" + result);

                    if (result)
                    {
                        return 2; //cadastra o ponto 2
                    }

                    else
                    {
                        sql = "SELECT * FROM ponto WHERE (CONVERT(date, dh_ponto1)) = CONVERT(date, CURRENT_TIMESTAMP) AND dh_ponto1 is not null and dh_ponto2 is not null and dh_ponto3 is null AND numregistro = @numRegistro";

                        //                       sqlcmd.Parameters.AddWithValue("@numRegistro", numRegistro);
                        rows = sqlcmd.ExecuteReader();
                        result = rows.Read();
                        rows.Close();
                        MessageBox.Show("" + result);

                        if (result)
                        {
                            return 3; //cadastra o ponto 3      
                        }

                        else
                        {
                            sql = " SELECT * FROM ponto WHERE (CONVERT(date, dh_ponto1)) = CONVERT(date, CURRENT_TIMESTAMP) AND dh_ponto1 is not null and dh_ponto2 is not null and dh_ponto3 is not null and dh_ponto4 is null AND numregistro =  @numRegistro";

                            conn = new SqlConnection(strConnection);
                            sqlcmd = new SqlCommand(sql, conn);

                            sqlcmd.Parameters.AddWithValue("@numRegistro", numRegistro);
                            result = rows.Read();

                            if (result)
                                return 4; //cadastra o ponto 4
                            else

                            return 5; //todos os pontos foram cadastrados
                        }
                    }
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
        }
        */

    }
