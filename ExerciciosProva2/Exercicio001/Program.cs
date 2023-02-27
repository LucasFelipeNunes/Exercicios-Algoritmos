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
            int auxiliar = 0, quantidadeNumerosPares = 0, quantidadeNumerosImpares = 0, maiorNumero = 0, menorNumero = 0;
            int[] vetorDeNumeros = new int[10];
            Console.WriteLine("Lucas Felipe da Silva Nunes - Matrícula 2211139 - Exercício 01\n");
            Console.WriteLine("Digite 10 números inteiros para serem armazenados em um vetor.");
            while(auxiliar < 10)
            {
                Console.Write($"Digite o {auxiliar + 1}º número: ");
                vetorDeNumeros[auxiliar] = int.Parse(Console.ReadLine());
                if(vetorDeNumeros[auxiliar]%2 == 0)
                {
                    quantidadeNumerosPares++;
                }
                else
                {
                    quantidadeNumerosImpares++;
                }
                if(vetorDeNumeros[auxiliar] > maiorNumero || auxiliar == 0)
                {
                    maiorNumero = vetorDeNumeros[auxiliar];
                }
                if (vetorDeNumeros[auxiliar] < menorNumero || auxiliar == 0)
                {
                    menorNumero = vetorDeNumeros[auxiliar];
                }
                auxiliar++;
            }
            Console.Write("\nOs números digitados foram:");
            for(int i = 0;i < 10;i++)
            {
                Console.Write(" " + vetorDeNumeros[i]);
            }
            Console.Write($"\nA quantidade de números pares digitados foi {quantidadeNumerosPares}\nA quanttidade de números ímpares digitados foi {quantidadeNumerosImpares}\nO maior número digitado foi {maiorNumero}\nO menor número digitado foi {menorNumero}\n");
        }
    }
}
