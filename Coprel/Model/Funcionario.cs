using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coprel.Model
{
    class Funcionario
    {
        private int NumeroRegistro;
        private string Senha;
        private DateTime DataNascimento;
        private string Nome;
        private string RG;
        private string CPF;
        private string CNH;
        private DateTime DataAdmissao;
        private string CTPS;
        private int CodFuncao;
        private int CodSetor;
        private string SenhaConfirmacao;

        public string GetSenhaConfirmacao()
        {
            return SenhaConfirmacao;
        }

        public void SetSenhaConfirmacao(string value)
        {
            this.SenhaConfirmacao = value;
        }

        public string GetCPF()
        {
            return CPF;
        }

        public void SetCPF(string value)
        {
            this.CPF = value;
        }

        public string GetCNH()
        {
            return CNH;
        }

        public void SetCNH(string value)
        {
            this.CNH = value;
        }

        public DateTime GetDataAdmissao()
        {
            return DataAdmissao;
        }

        public void SetDataAdmissao(DateTime value)
        {
            this.DataAdmissao = value;
        }

        public string GetCTPS()
        {
            return CTPS;
        }

        public void SetCTPS(string value)
        {
            this.CTPS = value;
        }

        public int GetCodFuncao()
        {
            return CodFuncao;
        }

        public void SetCodFuncao(int value)
        {
            this.CodFuncao = value;
        }

        public int GetCodSetor()
        {
            return CodSetor;
        }

        public void SetCodSetor(int value)
        {
            this.CodSetor = value;
        }

        public string GetRG()
        {
            return RG;
        }

        public void SetRG(string value)
        {
            this.RG = value;
        }

        public int GetNumeroRegistro()
        {
            return NumeroRegistro;
        }

        public void SetNumeroRegistro(int value)
        {
            this.NumeroRegistro = value;
        }

        public string GetSenha()
        {
               return Senha;
        }

        public void SetSenha(string value)
        {
               this.Senha = value;
        }

        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }

        public void SetDataNascimento(DateTime value)
        {
            this.DataNascimento = value;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string value)
        {
            this.Nome = value;
        }
    }
}
