using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio095
{
    class Program
    {
        static void Main(string[] args)
        {
            double somaNumeros = 0, mediaNumeros = 0;
            int qtdNumerosLidos = 0;
            Console.Write("Digite a quantidade inteira e positiva de números lidos pelo vetor: ");
            qtdNumerosLidos = int.Parse(Console.ReadLine());
            while (qtdNumerosLidos <= 0)
            {
                Console.Write("Valor inválido. Digite a quantidade inteira e positiva de números lidos pelo vetor: ");
                qtdNumerosLidos = int.Parse(Console.ReadLine());
            }
            int[] vetor = new int[qtdNumerosLidos];
            for(int auxiliar = 0;auxiliar < qtdNumerosLidos;auxiliar++){
                Console.Write($"Digite o número inteiro positivo que será armazenado na {auxiliar + 1}ª posição do vetor: ");
                vetor[auxiliar] = int.Parse(Console.ReadLine());
                while (vetor[auxiliar] <= 0)
                {
                    Console.Write($"Valor inválido. Digite o número inteiro positivo que será armazenado na {auxiliar + 1}ª posição do vetor: ");
                    vetor[auxiliar] = int.Parse(Console.ReadLine());
                }
                somaNumeros += vetor[auxiliar];
            }
            mediaNumeros = somaNumeros / qtdNumerosLidos;
            Console.WriteLine($"A média dos números lidos é {mediaNumeros}");

        }
    }
}
