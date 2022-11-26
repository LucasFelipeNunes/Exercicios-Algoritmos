using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio031
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            double numero3 = double.Parse(Console.ReadLine());
            Console.Write($"O resultado da soma destes três números é {numero1 + numero2 + numero3}, que é um número ");
            if((numero1 + numero2 + numero3)%2 == 0)
            {
                Console.WriteLine("par.");
            }
            else
            {
                Console.WriteLine("ímpar.");
            }
        }
    }
}
