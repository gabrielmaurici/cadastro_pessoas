using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Pessoa
{
    class PessoaFisica : Pessoa
    {
        public string RG { get; set; }
        public string CPF { get; set; }
        public Endereco Endereco { get; set; }

        public PessoaFisica(string rg, string cpf, Endereco endereco)
        {
            this.RG = rg;
            this.CPF = cpf;
            this.Endereco = endereco;
        }
    }
}
