using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio038
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            double valor2 = double.Parse(Console.ReadLine());
            double adicao = valor1 + valor2;
            Console.Write($"Os numeros digitados foram {valor1} e {valor2}, e o valor da soma deles é {adicao}");
            if (adicao > 10.0)
            {
                Console.WriteLine($", cuja raíz cúbica é {Math.Pow(adicao, 1.0 / 3.0)}");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
