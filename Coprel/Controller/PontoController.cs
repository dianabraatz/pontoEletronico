using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.DAO;
using Coprel.View;

namespace Coprel.Controller
{
    class PontoController
    {
        public static void ExecutaPonto(int numRegistro)
        {
            string sql;
            int resultado = 0;

            PontoDAO obj = new PontoDAO();
            int result = obj.VerificaPonto(numRegistro);
            MessageBox.Show("resultado do verifica ponto:" + result);

            switch (result)
            {
                case 1:
                    sql = "INSERT INTO ponto(dh_ponto1, numRegistro) VALUES (CURRENT_TIMESTAMP, @numRegistro);";
                    resultado = obj.CadastrarPonto(numRegistro, sql);
                    //MessageBox.Show(""+resultado);
                    break;

                case 2:
                    sql = "UPDATE ponto SET dh_ponto2 = CURRENT_TIMESTAMP WHERE CONVERT(date, dh_ponto1)= CONVERT(date, CURRENT_TIMESTAMP) AND numregistro = @numRegistro;";
                    resultado = obj.CadastrarPonto(numRegistro, sql);
                   // MessageBox.Show("" + resultado);

                    break;

                case 3:
                    sql = "UPDATE ponto SET dh_ponto3 = CURRENT_TIMESTAMP WHERE CONVERT(date, dh_ponto1)= CONVERT(date, CURRENT_TIMESTAMP) AND numregistro = @numRegistro;";
                    resultado = obj.CadastrarPonto(numRegistro, sql);
                    //MessageBox.Show("" + resultado);
                    break;

                case 4:
                    sql = "UPDATE ponto SET dh_ponto4 = CURRENT_TIMESTAMP WHERE CONVERT(date, dh_ponto1)= CONVERT(date, CURRENT_TIMESTAMP) AND numregistro = @numRegistro";
                    resultado = obj.CadastrarPonto(numRegistro, sql);
                    //MessageBox.Show("" + resultado);
                    break;

                case 5:
                    MessageBox.Show("O funcionário já cadastrou todos os pontos diários possiveis");
                    //MessageBox.Show("" + resultado);
                    resultado = 0;
                    break;
            }

            if(resultado == 1)
            {
                PontoFuncionarioView tela = new PontoFuncionarioView(numRegistro);
                tela.Show();
            }else
                MessageBox.Show("Ocorreu um erro na inserção do ponto.");

        }
    }
}
