using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.Arquivo;
using ProgramaCadastros.Conversores;

namespace ProgramaCadastros.Telas
{
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            Console.Clear();

            Console.WriteLine("Cadastrar Funcionário");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Data de Contratação: ");
            funcionario.DataContratacao = DateTime.Parse(Console.ReadLine());

            Console.Write("Salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.Write("Data de Nascimento: ");
            funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            funcionario.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            funcionario.CPF = Console.ReadLine();

            Console.Write("RG: ");
            funcionario.RG = Console.ReadLine();

            Console.Write("CEP(digitar apenas numeros): ");
            funcionario.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            funcionario.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            funcionario.Cidade = Console.ReadLine();

            Console.Write("Endereço: ");
            funcionario.Endereço = Console.ReadLine();

            GerenciadorArquivo.GravarArquivo("Funcionario", FuncionarioTexto.ConverterParaTexto(funcionario));
        }

        public void ListarFuncionario()
        {  
            Console.Clear();
            Console.WriteLine("LISTA DE FUNCIONARIO");
            string[] Linhas = GerenciadorArquivo.LerArquivo("funcionario");

            foreach (string linhas in Linhas)
            {
                Funcionario funcionario = Conversores.FuncionarioTexto.ConverterParaFuncionario(linhas);
                Console.WriteLine("Nome: " + funcionario.Nome);
                Console.WriteLine("Cargo: "+ funcionario.Cargo);
                Console.WriteLine("Data de Contratação: "+ funcionario.DataContratacao);
                Console.WriteLine("Salário: "+ funcionario.Salario);
                Console.WriteLine("Data de Nascimento: " + funcionario.DataNascimento);
                Console.WriteLine("Telefone: " + funcionario.Telefone);
                Console.WriteLine("CPF: " + funcionario.CPF);
                Console.WriteLine("RG: " + funcionario.RG);
                Console.WriteLine("CEP: " + funcionario.CEP);
                Console.WriteLine("Estado: " + funcionario.Estado);
                Console.WriteLine("Cidade: " + funcionario.Cidade);
                Console.WriteLine("Endereço: " + funcionario.Endereço);
            }
        }
    }
}
