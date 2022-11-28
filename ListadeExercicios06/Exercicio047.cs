using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio047
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, soma = 0;
            while(numero <= 100){
                soma += numero;
                numero++;
            }
            Console.WriteLine($"A soma dos números inteiros entre 0 e 100 é {soma}");
        }
    }
}
