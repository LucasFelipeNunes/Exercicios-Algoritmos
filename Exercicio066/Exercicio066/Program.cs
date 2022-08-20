using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio066
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0, B = 0, C = 0;
            do
            {
                Console.Write("Digite um número A maior que 0: ");
                A = double.Parse(Console.ReadLine());
                if (A <= 0)
                {
                    Console.Write("Número Inválido. ");
                }
            }
            while (A <= 0);
            do
            {
                Console.Write("Digite um número B maior que 0: ");
                B = double.Parse(Console.ReadLine());
                if (B <= 0)
                {
                    Console.Write("Número Inválido. ");
                }
            }
            while (B <= 0);
            if(A == B)
            {
                C = A + B;
                Console.WriteLine($"A e B são iguais e a soma C entre eles é {C}");
            }
            else
            {
                C = A * B;
                Console.WriteLine($"A e B são diferentes e o produto C entre eles é {C}");
            }
        }
    }
}
