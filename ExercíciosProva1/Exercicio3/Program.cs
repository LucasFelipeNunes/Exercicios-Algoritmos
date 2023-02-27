using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio003
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDigitado = 0, somaNumerosImparesEMultiplosDeCinco = 0;
            int quantidadeDeNumerosDigitados = 0, numerosMultiplosDeCinco = 0;
            Console.WriteLine("Lucas Felipe da Silva Nunes - Matrícula 2211139 - Exercício 03");
            Console.Write("Digite quantos números positivos ou nulos quiser, e quando não quiser mais digitar insira um número negativo.\n");
            do
            {
                Console.Write("Digite aqui: ");
                numeroDigitado = double.Parse(Console.ReadLine());
                if (numeroDigitado >= 0)
                {
                    quantidadeDeNumerosDigitados++;
                    if (numeroDigitado % 5 == 0)
                    {
                        numerosMultiplosDeCinco++;
                    }
                    if (numeroDigitado % 2 == 1 || numeroDigitado % 5 == 0)
                    {
                        somaNumerosImparesEMultiplosDeCinco += numeroDigitado;
                    }
                }
            } while (numeroDigitado >= 0);
            Console.WriteLine($"A quantidade de números digitados múltiplos de 5 é {numerosMultiplosDeCinco}\nA quantidade de numeros digitados é {quantidadeDeNumerosDigitados}\nA soma dos números ímpares e múltiplos de 5 é {somaNumerosImparesEMultiplosDeCinco}");
        }
    }
}
