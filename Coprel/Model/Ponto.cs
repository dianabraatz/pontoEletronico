using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coprel.Model
{
    class Ponto
    {
        DateTime ponto1;
        DateTime ponto2;
        DateTime ponto3;
        DateTime ponto4;
        int codigo;
        int numeroRegistro;

        public int getNumeroRegistro()
        {
            return numeroRegistro;
        }

        public void setNumeroRegistro(int numeroRegistro)
        {
            this.numeroRegistro = numeroRegistro;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public DateTime getPonto1()
        {
            return ponto1;
        }

        public void setPonto1(DateTime ponto)
        {
            this.ponto1 = ponto;
        }

        public DateTime getPonto2()
        {
            return ponto2;
        }

        public void setPonto3(DateTime ponto)
        {
            this.ponto3 = ponto;
        }

        public DateTime getPonto4()
        {
            return ponto4;
        }
    }

}

