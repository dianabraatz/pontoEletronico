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
    public partial class PontoFuncionarioView : Form
    {
        public PontoFuncionarioView(int numRegistro)
        {
            InitializeComponent();
            //PontoController.ExecutaPonto(numRegistro); 
            MessageBox.Show(""+numRegistro);
        }

        private void PontoFuncionarioView_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
