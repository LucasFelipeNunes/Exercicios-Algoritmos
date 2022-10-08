using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio051
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());
            int soma = 0;
            if (numero2 < numero1)
            {
                while (numero2 <= numero1)
                {
                    if (numero2%2 == 0)
                    {
                        soma += numero2;
                    }
                    numero2++;
                }
            }
            else
            {
                while (numero1 <= numero2)
                {
                    if (numero1%2 == 0)
                    {
                        soma += numero1;
                    }
                    numero1++;
                }
            }
            Console.WriteLine($"A soma dos números compreendidos entre estes digitados é {soma}");
        }
    }
}
