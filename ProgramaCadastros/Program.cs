using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.Arquivo;
using ProgramaCadastros.Telas;
using System.IO;

namespace ProgramaCadastros
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcoes = 0;

            while(opcoes != 5)
            {
                Console.WriteLine("O que deseja fazer? \n 1= Cadastrar Cliente, 2= Listar Cliente, 3= Cadastrar Funcionário, 4= Listar Funcionário, 5= Sair.");
                opcoes = int.Parse(Console.ReadLine());
                ManterCliente TelaCliente = new ManterCliente();
                ManterFuncionario TelaFuncionario = new ManterFuncionario();
                
                switch (opcoes)
                {
                    case 1:
                        TelaCliente.CadastrarCliente();
                        break;
                    case 2:
                        TelaCliente.ListarCliente();
                        break;
                    case 3:
                        TelaFuncionario.CadastrarFuncionario();
                        break;
                    case 4:
                        TelaFuncionario.ListarFuncionario();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Comando não encontrado.");
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
