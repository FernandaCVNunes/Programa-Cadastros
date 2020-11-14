using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.Arquivo;

namespace ProgramaCadastros.Conversores
{
    class FuncionarioTexto
    {
        public static string ConverterParaTexto(Funcionario funcionario)
        {
            string texto = string.Format("{0} , {1} , {2} , {3} , {4} , {5} , {6} , {7}, {8}, {9} , {10}, {11}",
            funcionario.Nome,
            funcionario.Cargo,
            funcionario.DataContratacao,
            funcionario.Salario,
            funcionario.DataNascimento,
            funcionario.Telefone,
            funcionario.CPF,
            funcionario.RG,
            funcionario.CEP,
            funcionario.Estado,
            funcionario.Cidade,
            funcionario.Endereço);
            return texto;
        }

        public static Funcionario ConverterParaFuncionario(string linha)
        {
            string[] elemento = linha.Split(',');
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = elemento[0];
            funcionario.Cargo = elemento[1];
            funcionario.DataContratacao = DateTime.Parse(elemento[2]);
            funcionario.Salario = double.Parse(elemento[3]);
            funcionario.DataNascimento = DateTime.Parse(elemento[4]);
            funcionario.Telefone = elemento[5];
            funcionario.CPF = elemento[6];
            funcionario.RG = elemento[7];
            funcionario.CEP = int.Parse(elemento[8]);
            funcionario.Estado = elemento[9];
            funcionario.Cidade = elemento[10];
            funcionario.Endereço = elemento[11];
            return funcionario;
        }
    }
}
