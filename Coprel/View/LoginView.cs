using System;
using System.Windows.Forms;
using Coprel.Controller;

namespace Coprel
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FuncionarioController.VerificaUsuario(this);
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
