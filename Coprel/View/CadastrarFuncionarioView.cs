﻿using System;
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

            tfNumeroRegistro.Focus();
            tfConfirmaSenha.Enabled = false;
        }

        private void FuncionarioView_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FuncionarioController f = new FuncionarioController();
            f.CadastrarFuncionario(this);
        }

        private void tfSenha_Leave(object sender, EventArgs e)
        {
            if(this.tfSenha.Text != string.Empty)
            {
                tfConfirmaSenha.Enabled = true;
            }
        }

        private void tfSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
