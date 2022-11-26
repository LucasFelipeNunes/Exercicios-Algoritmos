using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio103
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDigitado = 0;
            double[] vetorPares = new double[10], vetorImpares = new double[10];
            for (int auxiliar = 0; auxiliar < 10; auxiliar++)
            {
                Console.Write($"Digite o {auxiliar + 1}º número diferente de 0: ");
                numeroDigitado = double.Parse(Console.ReadLine());
                while (numeroDigitado == 0)
                {
                    Console.Write($"Valor inválido (nulo). Digite o {auxiliar + 1}º número diferente de 0: ");
                    numeroDigitado = double.Parse(Console.ReadLine());
                }
                if (numeroDigitado % 2 == 0)
                {
                    vetorPares[auxiliar] = numeroDigitado;
                }
                else
                {
                    vetorImpares[auxiliar] = numeroDigitado;
                }
            }
            Console.Write("Valores não nulos do vetor de números pares:");
            for (int auxiliar = 0; auxiliar < 10; auxiliar++)
            {
                if (vetorPares[auxiliar] != 0)
                {
                    Console.Write($" {vetorPares[auxiliar]}");
                }
            }
            Console.Write("\nValores não nulos do vetor de números ímpares:");
            for (int auxiliar = 0; auxiliar < 10; auxiliar++)
            {
                if (vetorImpares[auxiliar] != 0)
                {
                    Console.Write($" {vetorImpares[auxiliar]}");
                }
            }
            Console.WriteLine();
        }
    }
}
