using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.View;
using Coprel.Controller;

namespace Coprel.View
{
    public partial class VisualizarFuncionarioView : Form
    {
        public VisualizarFuncionarioView()
        {
            InitializeComponent();
            FuncionarioController.PreencherTabela(this);

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnVisualizar.Enabled = false;
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            CadastrarFuncionarioView obj = new CadastrarFuncionarioView();
            obj.Show();
        }
    }
}
