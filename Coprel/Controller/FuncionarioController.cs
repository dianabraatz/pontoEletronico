using Coprel.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.View;
using Coprel.Model;

namespace Coprel.Controller
{
    class FuncionarioController
    {

        public static void VerificaUsuario(LoginView tela)
        {

            int numRegistro = Convert.ToInt32(tela.tfNumeroRegistro.Text);
            string senha = tela.tfSenha.Text;

            FuncionarioDAO obj = new FuncionarioDAO();
            bool result = obj.verificaLogin(numRegistro, senha);

            if (result)
            {
                VerificaNivelAcesso(numRegistro, senha);
            }
            else
                MessageBox.Show("Erro ao efetuar login");
        }

        public static void VerificaNivelAcesso(int numRegistro, string senha)
        {
            FuncionarioDAO obj = new FuncionarioDAO();
            int nivelAcesso = obj.VerificaNivelAcesso(numRegistro, senha);

            if (nivelAcesso == 1)
            {
                PontoAdministradorView telaAdmin = new PontoAdministradorView(numRegistro);
                telaAdmin.Show();
            }
            else
            {
                PontoController.ExecutaPonto(numRegistro);
            }
        }


    }
}
