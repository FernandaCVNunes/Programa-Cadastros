using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public abstract class Pessoa
    {
        public string Nome { set; get; }
        public DateTime DataNascimento { set; get; }
        public string Telefone { set; get; }
        public string CPF { set; get; }
        public string RG { set; get; }
        public int CEP { set; get; }
        public string Cidade { set; get; }
        public string Estado { set; get; }
        public string Endereço { set; get; }
    }
}
