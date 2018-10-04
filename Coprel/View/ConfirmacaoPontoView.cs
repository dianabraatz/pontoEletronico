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

        private void button1_Click(object sender, EventArgs e)
        {
            LoginView obj = new LoginView();
            obj.Show();
            this.Close();
        }
    }
}
