using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio096
{
    class Program
    {
        static void Main(string[] args)
        {
            double somaNumeros = 0;
            double[] numeros = new double[5];
            for (int auxiliar = 0; auxiliar < 5; auxiliar++)
            {
                Console.Write($"Digite o {auxiliar + 1}º número: ");
                numeros[auxiliar] = double.Parse(Console.ReadLine());
                somaNumeros += numeros[auxiliar];
            }
            Console.WriteLine($"A soma dos números digitados é {somaNumeros}\nOs números digitados foram:");
            for (int auxiliar = 0; auxiliar < 5; auxiliar++)
            {
                Console.WriteLine(numeros[auxiliar]);
            }
        }
    }
}
