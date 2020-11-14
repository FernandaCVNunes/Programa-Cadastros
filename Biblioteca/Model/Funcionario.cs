using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public sealed class Funcionario : Pessoa
    {
        public string Cargo { set; get; }
        public double Salario { set; get; }
        public DateTime DataContratacao { set; get; }
    }
}
