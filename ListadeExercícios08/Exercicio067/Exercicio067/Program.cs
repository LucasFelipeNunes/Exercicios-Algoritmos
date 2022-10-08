using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio067
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"Este número somado a 5 vira {numero + 5}");
                }
                else
                {
                    Console.WriteLine($"Este número somado a 8 vira {numero + 8}");
                }
            }
            while (true);
        }
    }
}
