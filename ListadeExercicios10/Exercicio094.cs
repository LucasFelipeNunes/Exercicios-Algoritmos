using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio094
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[50];
            int qtdPares = 0, qtdMultiplos5 = 0;
            for (int auxiliar = 0; auxiliar < 50; auxiliar++)
            {
                Console.Write($"Digite o número inteiro positivo que será armazenado na {auxiliar + 1}ª posição do vetor: ");
                vetor[auxiliar] = int.Parse(Console.ReadLine());
                while (vetor[auxiliar] <= 0)
                {
                    Console.Write($"Valor inválido. Digite o número inteiro positivo que será armazenado na {auxiliar + 1}ª posição do vetor: ");
                    vetor[auxiliar] = int.Parse(Console.ReadLine());
                }
                if(vetor[auxiliar]%2 == 0)
                {
                    qtdPares++;
                }
                if (vetor[auxiliar] % 5 == 0)
                {
                    qtdMultiplos5++;
                }
            }
            Console.WriteLine($"A quantidade de números pares digitados é {qtdPares}\nA quantidade de números múltiplos de cinco digitados é {qtdMultiplos5}");
        }
    }
}
