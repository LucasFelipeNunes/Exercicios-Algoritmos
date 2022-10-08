using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio083
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("TABELA DE CONVERSÃO ENTRE POLEGADAS E CENTÍMETROS\nValor em polegadas\tValor em centímetros");
            for(int aux = 0;aux < 20; aux++)
            {
                Console.Write($"\n\t{aux + 1}\t\t\t{(aux + 1) * 25.4}");
            }
            Console.Write("\n");
        }
    }
}
