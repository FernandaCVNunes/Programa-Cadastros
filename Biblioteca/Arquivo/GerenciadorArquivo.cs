using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca.Arquivo
{
    public class GerenciadorArquivo
    {
        public static void GravarArquivo(string nome, string texto)
        {
            string caminho = "Arquivos" + nome + ".txt";

            string valor = AppDomain.CurrentDomain.BaseDirectory + caminho;

            if (File.Exists(caminho))
            {
                using (StreamWriter wr = File.AppendText(caminho))
                {
                    wr.WriteLine(texto);
                }
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(caminho)) {
                    wr.WriteLine(texto);
                }
            }
        }

        public static string[] LerArquivo(string nome)
        {
            string caminho = "Arquivos" + nome + ".txt";
            return File.ReadAllLines(caminho);
        }
    }
}
