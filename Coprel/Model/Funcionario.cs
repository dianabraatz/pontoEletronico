using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coprel.Model
{
    class Funcionario
    {
        int numeroRegistro;
        String senha;

        public int getNumeroRegistro()
        {
            return numeroRegistro;
        }

        public void setNumeroRegistro(int numeroRegistro)
        {
            this.numeroRegistro = numeroRegistro;
        }

        public String getSenha()
        {
            return senha;
        }

        public void setSenha(String senha)
        {
            this.senha = senha;
        }

    }
}
