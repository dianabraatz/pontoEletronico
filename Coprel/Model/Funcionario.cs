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

                public int GetNumeroRegistro()
                {
                    return numeroRegistro;
                }

                public void SetNumeroRegistro(int numeroRegistro)
                {
                    this.numeroRegistro = numeroRegistro;
                }

                public string GetSenha()
                {
                    return senha;
                }

                public void SetSenha(string senha)
                {
                    this.senha = senha;
                }
                

    }
}
