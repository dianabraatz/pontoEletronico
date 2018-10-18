using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.Controller;

namespace Coprel.View
{
    public partial class CadastrarFuncionarioView : Form
    {
        public CadastrarFuncionarioView()
        {
            InitializeComponent();
            FuncionarioController.PreencheCBFuncao(this);
            FuncionarioController.PreencheCBSetor(this);

            tfNumeroRegistro.Select();
            tfConfirmaSenha.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FuncionarioController f = new FuncionarioController();
            f.CadastrarFuncionario(this);
        }

        private void tfSenha_Leave(object sender, EventArgs e)
        {
            if (this.tfSenha.Text != string.Empty)
            {
                tfConfirmaSenha.Enabled = true;
                btnCadastrar.Enabled = true;
            }
            else
                tfConfirmaSenha.Enabled = false;
        }
    }
}
