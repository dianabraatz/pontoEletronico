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
        int numeroRegistro = 0;
        public VisualizarFuncionarioView()
        {
            InitializeComponent();
            FuncionarioController.PreencherTabela(this);
            PreencheCBFiltro();

            cbFiltro.SelectedIndex = 0;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnVisualizar.Enabled = false;
            tfBuscar.Enabled = false;
            btnFiltrar.Enabled = false;

        }

        private void PreencheCBFiltro()
        {
            cbFiltro.Items.Insert(0, "Selecione o filtro");
            cbFiltro.Items.Insert(1, "Nome");
            cbFiltro.Items.Insert(2, "Setor");
            cbFiltro.Items.Insert(3, "Função");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
                FuncionarioController.ExecutarFiltro(this);
          
        }

        private void tfBuscar_Enter(object sender, EventArgs e)
        {
            tfBuscar.Text = "";
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            FuncionarioController.PreencherTabela(this);
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex != 0)
            {
                tfBuscar.Enabled = true;
            }
            else
                tfBuscar.Enabled = false;                
        }

        private void tfBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tfBuscar.Text != String.Empty)
            {
                btnFiltrar.Enabled = true;
            }
            else
                btnFiltrar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int numeroRegistro = Convert.ToInt32(tabela.CurrentRow.Cells[0].Value.ToString());

            EditarFuncionarioView obj = new EditarFuncionarioView(numeroRegistro);
            obj.Show();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            EditarFuncionarioView obj = new EditarFuncionarioView(numeroRegistro);
        }

        private void btnCadastrarFuncionario_Click_1(object sender, EventArgs e)
        {
            CadastrarFuncionarioView obj = new CadastrarFuncionarioView();
            obj.Show();
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
