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
    public partial class EditarFuncionarioView : Form
    {
        public EditarFuncionarioView(int numeroRegistro)
        {
            InitializeComponent();
            FuncionarioController.PreencheCampos(this, numeroRegistro);
            //vai receber a linha inteira ou o numero de registro do funcionario
            //executa consulta no banco e altera os campos

        }

        private void EditarFuncionarioView_Load(object sender, EventArgs e)
        {

        }
    }
}
