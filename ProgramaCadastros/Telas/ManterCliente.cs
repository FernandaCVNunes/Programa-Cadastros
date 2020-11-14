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
    class ManterCliente
    {
        public void CadastrarCliente()
        {
            Cliente cliente = new Cliente();
            Console.Clear();

            Console.WriteLine("Cadastrar Cliente");

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.Write("RG: ");
            cliente.RG = Console.ReadLine();

            Console.Write("CEP(digitar apenas numeros): ");
            cliente.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            cliente.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            cliente.Cidade = Console.ReadLine();

            Console.Write("Endereço: ");
            cliente.Endereço = Console.ReadLine();

            GerenciadorArquivo.GravarArquivo("Cliente",ClienteTexto.ConverterParaTexto(cliente));
        }

        public void ListarCliente()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE CLIENTES");
            string[] Linhas = GerenciadorArquivo.LerArquivo("Cliente");

            foreach(string linhas in Linhas)
            {
                Cliente cliente = Conversores.ClienteTexto.ConverterParaCliente(linhas);
                Console.WriteLine("Nome: "+cliente.Nome);
                Console.WriteLine("Data de Nascimento: "+ cliente.DataNascimento);
                Console.WriteLine("Telefone: "+ cliente.Telefone);
                Console.WriteLine("CPF: "+ cliente.CPF);
                Console.WriteLine("RG: "+ cliente.RG);
                Console.WriteLine("CEP: " + cliente.CEP);
                Console.WriteLine("Estado: "+ cliente.Estado);
                Console.WriteLine("Cidade: "+ cliente.Cidade);
                Console.WriteLine("Endereço: "+ cliente.Endereço);
            }
        }
    }
}
