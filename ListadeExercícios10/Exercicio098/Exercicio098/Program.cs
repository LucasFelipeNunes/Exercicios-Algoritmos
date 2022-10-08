using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio098
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[10], vetorMultiplicadoPor5 = new double[10];
            for (int auxiliar = 0; auxiliar < 10; auxiliar++)
            {
                Console.Write($"Digite o {auxiliar + 1}º elemento do vetor: ");
                vetor[auxiliar] = double.Parse(Console.ReadLine());
                vetorMultiplicadoPor5[auxiliar] = vetor[auxiliar] * 5;
            }
            Console.WriteLine("Números Digitados\tNúmeros Digitados Multiplicados por 5");
            for (int auxiliar = 0; auxiliar < 10; auxiliar++)
            {
                Console.WriteLine($"\t{vetor[auxiliar]}\t\t\t\t{vetorMultiplicadoPor5[auxiliar]}");
            }
        }
    }
}
