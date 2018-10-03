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
    public partial class ConfirmacaoPontoView : Form
    {
        public ConfirmacaoPontoView(int numRegistro)
        {
            InitializeComponent();
            PontoController.ConfirmaPonto(numRegistro, this);
        }

        private void PontoFuncionarioView_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void hora_Click(object sender, EventArgs e)
        {

        }

        private void data_Click(object sender, EventArgs e)
        {

        }

        private void numRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
