using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio029
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            double numero2 = double.Parse(Console.ReadLine());
            double soma = numero1 + numero2;
            Console.Write($"Os números digitados foram {numero1} e {numero2}, a sua soma é {soma}");
            if (soma > 10)
            {
                Console.WriteLine($" e a raíz cúbica desta soma é {Math.Pow(soma, 1.0 / 3.0)}");
            }
            else
            {
                Console.Write("\n");
            }
        }
    }
}
