using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio056
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 990, soma = 0;
            while(numero > 0)
            {
                soma += numero;
                numero -= 15;
            }
            Console.WriteLine($"A soma dos números abaixo de 1000 que são múltiplos de 3 e 5 é {soma}");
        }
    }
}
