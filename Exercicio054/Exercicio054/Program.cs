using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio054
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroPar = 2, soma = 0;
            while(numeroPar <= 100)
            {
                soma += numeroPar;
                numeroPar += 2;
            }
            Console.WriteLine($"A soma dos 50 primeiros números pares é {soma}");
        }
    }
}
