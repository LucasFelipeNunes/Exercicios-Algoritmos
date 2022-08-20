using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio053
{
    class Program
    {
        static void Main(string[] args)
        {
            int auxiliar = 0;
            double numero = 0;
            while(auxiliar < 5)
            {
                Console.Write($"Digite o número {auxiliar + 1}: ");
                numero = double.Parse(Console.ReadLine());
                auxiliar++;
                Console.WriteLine($"Este número ao quadrado é {Math.Pow(numero, 2)}");
            }
        }
    }
}
