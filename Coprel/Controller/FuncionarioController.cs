using Coprel.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.View;
using Coprel.Model;
using System.Data;

namespace Coprel.Controller
{
    class FuncionarioController
    {

        public static void VerificaUsuario(LoginView tela)
        {

            int numRegistro = Convert.ToInt32(tela.tfNumeroRegistro.Text);
            string senha = tela.tfSenha.Text;

            Funcionario f = new Funcionario();
            f.SetNumeroRegistro(numRegistro);
            f.SetSenha(senha);

            FuncionarioDAO obj = new FuncionarioDAO();
            bool result = obj.verificaLogin(f);

            if (result)
            {
                VerificaNivelAcesso(f);
            }
            else
                MessageBox.Show("Erro ao efetuar login");
        }

        public static void VerificaNivelAcesso(Funcionario f)
        {
            FuncionarioDAO obj = new FuncionarioDAO();
            int nivelAcesso = obj.VerificaNivelAcesso(f);

            if (nivelAcesso == 1)
            {
                PontoAdministradorView telaAdmin = new PontoAdministradorView(f.GetNumeroRegistro());
                telaAdmin.Show();
            }
            else
            {
                PontoController.ExecutaPonto(f.GetNumeroRegistro());
            }
        }

        public static void PreencheCBFuncao(CadastrarFuncionarioView tela)
        {
            DataTable data = FuncionarioDAO.PreencheCBFuncao();
            tela.cbFuncao.DataSource = data;
            tela.cbFuncao.ValueMember = "codFuncao";
            tela.cbFuncao.DisplayMember = "nome";
        }

        public static void PreencheCBSetor(CadastrarFuncionarioView tela)
        {
            DataTable data = FuncionarioDAO.PreencheCBSetor();
            tela.cbSetor.DataSource = data;
            tela.cbSetor.ValueMember = "codSetor";
            tela.cbSetor.DisplayMember = "nome";
        }

        public static bool VerificaCampos(CadastrarFuncionarioView tela)
        {
            if (tela.tfNumeroRegistro.Text == string.Empty)
            {
                tela.tfNumeroRegistro.Focus();
                return true;
            }

            else if (tela.tfNome.Text == string.Empty)
            {
                tela.tfNome.Focus();
                return true;
            }

            else if (tela.tfSenha.Text == string.Empty)
            {
                tela.tfSenha.Focus();
                return true;
            }

            else if (tela.tfConfirmaSenha.Text == string.Empty)
            {
                tela.tfConfirmaSenha.Focus();
                return true;
            }

            else if (tela.tfDataNascimento.Text == string.Empty)
            {
                tela.tfDataNascimento.Focus();
                return true;
            }

            else if (tela.tfDataAdmissao.Text == string.Empty)
            {
                tela.tfDataAdmissao.Focus();
                return true;
            }

            else if (tela.tfCPF.Text == string.Empty)
            {
                tela.tfCPF.Focus();
                return true;
            }

            else if (tela.tfCTPS.Text == string.Empty)
            {
                tela.tfCTPS.Focus();
                return true;
            }

            else if (tela.tfRG.Text == string.Empty)
            {
                tela.tfRG.Focus();
                return true;
            }

            else if (tela.tfCNH.Text == string.Empty)
            {
                tela.tfCNH.Focus();
                return true;
            }

            //           else if (tela.cbFuncao.SelectedIndex == 0)
            //               return true;
            //           else if (tela.cbSetor.SelectedIndex == 0)
            //               return true;
            else
                return false;
        }

        public static bool VerificaSenhas(string senha, string confirma)
        {
            if (senha.Equals(confirma))
                return true;
            else
                return false;
        }

        public void CadastrarFuncionario(CadastrarFuncionarioView tela)
        {
            if (!VerificaCampos(tela))
            {
                tela.tfCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                tela.tfRG.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                //OBTEM VALORES
                int NumeroRegistro = Convert.ToInt32(tela.tfNumeroRegistro.Text);
                string Senha = (tela.tfSenha.Text);
                string SenhaConfirmacao = tela.tfConfirmaSenha.Text;
                DateTime DataNascimento = Convert.ToDateTime(tela.tfDataNascimento.Text);
                string Nome = tela.tfNome.Text;
                string RG = tela.tfRG.Text;
                string CPF = tela.tfCPF.Text;
                string CNH = tela.tfCNH.Text;
                DateTime DataAdmissao = Convert.ToDateTime(tela.tfDataAdmissao.Text);
                string CTPS = tela.tfCTPS.Text;
                int CodFuncao = Convert.ToInt32(tela.cbFuncao.SelectedValue);
                int CodSetor = Convert.ToInt32(tela.cbFuncao.SelectedValue);

                //VERIFICA SE A SENHA ESTÁ CORRETA
                if (VerificaSenhas(Senha, SenhaConfirmacao))
                {
                    //SETA NO OBJETO
                    Funcionario f = new Funcionario();
                    f.SetNumeroRegistro(NumeroRegistro);
                    f.SetNome(Nome);
                    f.SetDataNascimento(DataNascimento);
                    f.SetCPF(CPF);
                    f.SetRG(RG);
                    f.SetCNH(CNH);
                    f.SetCTPS(CTPS);
                    f.SetDataAdmissao(DataAdmissao);
                    f.SetSenha(Senha);
                    f.SetSenhaConfirmacao(SenhaConfirmacao);
                    f.SetCodFuncao(CodFuncao);
                    f.SetCodSetor(CodSetor);

                    //EXECUTA CONSULTA
                    FuncionarioDAO obj = new FuncionarioDAO();
                    int resultado = obj.CadastraFuncionario(f);

                    if (resultado == 1)
                    {
                        MessageBox.Show("Funcionário cadastrado com sucesso.");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Erro ao cadastrar usuário, deseja tentar novamente?", "Erro no cadastro", MessageBoxButtons.RetryCancel);
                        if (dr == DialogResult.Cancel)
                        {
                            tela.Close();
                        }
                    }
                }
                else
                    MessageBox.Show("As senhas digitadas não conferem. Repita o processo novamente.");
            }
            else
                MessageBox.Show("Preencha todos os campos para cadastrar o funcionario.");
        }

        public static void LimparCampos(CadastrarFuncionarioView tela)
        {
            tela.tfNumeroRegistro.Text = "";
            tela.tfNome.Text = "";
            tela.tfRG.Text = "";
            tela.tfCNH.Text = "";
            tela.tfCNH.Text = "";
            tela.tfDataNascimento.Text = "";
            tela.tfDataAdmissao.Text = "";
            tela.tfCTPS.Text = "";
            tela.tfSenha.Text = "";
            tela.tfConfirmaSenha.Text = "";
            tela.cbFuncao.SelectedIndex = 0;
            tela.cbSetor.SelectedIndex = 0;

            tela.tfConfirmaSenha.Enabled = false;
            tela.btnCadastrar.Enabled = false;

        }

        public static void PreencherTabela(VisualizarFuncionarioView tela)
        {
            DataSet ds = FuncionarioDAO.PreencheTabela();
            tela.tabela.DataSource = ds;
            tela.tabela.DataMember = ds.Tables[0].TableName;
        }
    }
}

