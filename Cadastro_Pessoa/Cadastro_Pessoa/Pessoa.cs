using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Pessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {

        }
        public Pessoa(string nome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
        }
    }
}
