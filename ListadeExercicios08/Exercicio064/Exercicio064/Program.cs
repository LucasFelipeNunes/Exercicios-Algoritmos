using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio064
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0;
            do
            {
                Console.Write("Digite um número maior que 0 e menor ou igual a 100: ");
                n1 = double.Parse(Console.ReadLine());
                if (n1 <= 0 || n1 > 100)
                {
                    Console.Write("Número inválido. ");
                }
            }
            while (n1 <= 0 || n1 > 100);
            do
            {
                Console.Write("Digite outro número maior que 0 e menor ou igual a 100: ");
                n2 = double.Parse(Console.ReadLine());
                if (n2 <= 0 || n2 > 100)
                {
                    Console.Write("Número inválido. ");
                }
            }
            while (n2 <= 0 || n2 > 100);
            if(n1 < n2)
            {
                Console.WriteLine($"O primeiro número digitado, {n1}, é o menor dos dois");
            }
            else if (n2 < n1)
            {
                Console.WriteLine($"O segundo número digitado, {n2}, é o menor dos dois");
            }
            else
            {
                Console.WriteLine("Os dois números digitados são iguais.");
            }
        }
    }
}
