using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lucas Felipe da Silva Nunes - Matrícula 2211139 - Exercício 01");
            Console.Write("Digite um número inteiro positivo com 5 dígitos ou mais: ");
            int numeroDigitado = int.Parse(Console.ReadLine());
            if (numeroDigitado <= 9999)
            {
                Console.WriteLine("erro");
            }
            else
            {
                Console.WriteLine($"O algarismo da casa do milhar do número digitado é {numeroDigitado / 1000 % 10}");
            }
        }
    }
}
