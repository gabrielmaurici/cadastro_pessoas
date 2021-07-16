using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Pessoa
{
    class PessoaJuridica : Pessoa
    {
        public string IE { get; set; }
        public string CNPJ { get; set; }
        public Endereco Endereco { get; set; }
        public PessoaJuridica(string ie, string cnpj, Endereco endereco)
        {
            this.IE = ie;
            this.CNPJ = cnpj;
            this.Endereco = endereco;
        }
    }
}
