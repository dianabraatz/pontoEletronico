using Coprel.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coprel.View
{
    public partial class PontoAdministradorView : Form
    {
        int numRegistro;

        public PontoAdministradorView(int registro)
        {
            InitializeComponent();
             numRegistro = registro;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PontoController.ExecutaPonto(numRegistro);
        }
    }
}
