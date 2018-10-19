using Coprel.DAO;
using Coprel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coprel.Controller
{
    class SetorController
    {


        public static bool VerificaCamposSetor(CadastrarSetorView tela)
        {
            if (tela.tsCodSetor.Text == string.Empty)
            {
                tela.tsCodSetor.Focus();
                return true;
            }

            else if (tela.tsNome.Text == string.Empty)
            {
                tela.tsNome.Focus();
                return true;
            }

            else
                return false;
        }

        public void CadastrarSetor(CadastrarSetorView tela)
        {
            if (!VerificaCamposSetor(tela))
            {
                //OBTEM VALORES
                int CodSetor = Convert.ToInt32(tela.tsCodSetor.Text);
                string Nome = tela.tsNome.Text;
                
               //SETA NO OBJETO
                Setor s = new Setor();
                s.SetCodSetor(CodSetor);
                s.SetNome(Nome);
                    
                //EXECUTA CONSULTA
                SetorDAO obj = new DAO.SetorDAO();
                int resultado = obj.CadastraSetor(s);

                if (resultado == 1)
                {
                    MessageBox.Show("Setor cadastrado com sucesso.");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Erro ao cadastrar setor, deseja tentar novamente?", "Erro no cadastro", MessageBoxButtons.RetryCancel);
                    if (dr == DialogResult.Cancel)
                    {
                        tela.Close();
                    }
                }
            }
            else
                MessageBox.Show("Preencha todos os campos para cadastrar o setor.");
        }

        public static void LimparCamposSetor(CadastrarSetorView tela)
        {
            tela.tsCodSetor.Text = "";
            tela.tsfNome.Text = "";
            
            tela.tfConfirmaSenha.Enabled = false;
            tela.btnCadastrar.Enabled = false;

        }

        public static void PreencherTabelaSetor(VisualizarSetorView tela)
        {
            DataSet ds = FuncionarioDAO.PreencheTabela();
            //ds.
            tela.tabela.DataSource = ds;
            tela.tabela.DataMember = ds.Tables[0].TableName;
        }

        public static void ExecutarFiltroSetor(VisualizarSetorView tela)
        {

            string sql = "";
            string valor = tela.tsBuscar.Text;
            int filtro = tela.cbFiltro.SelectedIndex;

            if (filtro != 0)
            {
                if (!String.IsNullOrEmpty(valor))
                {
                    //DataSet ds;
                    switch (filtro)
                    {
                        case 1:
                            sql = "SELECT s.codSetor as 'Código do Setor', s.nome as 'Nome do Setor' FROM setor s WHERE s.nome LIKE @valor";
                            break;
                    }
                    DataSet ds = FuncionarioDAO.ExecutaFiltro(sql, valor);
                    tela.tabela.DataSource = ds;
                    tela.tabela.DataMember = ds.Tables[0].TableName;
                }
            }
            else
                MessageBox.Show("Selecione algum filtro.");
        }
    }
}
