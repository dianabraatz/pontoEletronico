using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coprel.Model
{
    class Setor
    {
        private int CodSetor;
        private string Nome;

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string value)
        {
            this.Nome = value;
        }

        public int GetCodSetor()
        {
            return CodSetor;
        }

        public void SetCodSetor(int value)
        {
            this.CodSetor = value;
        }
    }
}
