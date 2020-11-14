using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace ProgramaCadastros.Conversores
{
    public class ClienteTexto
    {
        public static string ConverterParaTexto(Cliente cliente)
        {
            string texto = string.Format("{0} , {1} , {2} , {3} , {4} , {5} , {6} , {7}, {8}",
            cliente.Nome,
            cliente.DataNascimento,
            cliente.Telefone,
            cliente.CPF,
            cliente.RG,
            cliente.CEP,
            cliente.Estado,
            cliente.Cidade,
            cliente.Endereço);
            return texto;
        }

        public static Cliente ConverterParaCliente(string linha)
        {
            string[] elemento = linha.Split(',');
            Cliente cliente = new Cliente();
            cliente.Nome = elemento[0];
            cliente.DataNascimento = DateTime.Parse(elemento[1]);
            cliente.Telefone = elemento[2];
            cliente.CPF = elemento[3];
            cliente.RG = elemento[4];
            cliente.CEP = int.Parse(elemento[5]);
            cliente.Estado = elemento[6];
            cliente.Cidade = elemento[7];
            cliente.Endereço = elemento[8];
            return cliente;
        }
    }
}
