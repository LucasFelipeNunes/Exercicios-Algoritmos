using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio072
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            for(int i = 0;i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numero = double.Parse(Console.ReadLine());
                Console.WriteLine($"Este número ao quadrado é {Math.Pow(numero, 2)}");
            }
        }
    }
}
