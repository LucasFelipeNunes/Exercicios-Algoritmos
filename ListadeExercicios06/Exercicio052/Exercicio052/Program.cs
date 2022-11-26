using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio052
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite números até que digitar um número negativo\n");
            int numero = 0, maiorNumero = -1, menorNumero = -1;
            while(numero >= 0)
            {
                Console.Write("Digite aqui: ");
                numero = int.Parse(Console.ReadLine());
                if (numero > maiorNumero || maiorNumero < 0)
                {
                    maiorNumero = numero;
                }
                if (numero < menorNumero || menorNumero < 0)
                {
                    menorNumero = numero;
                }
            }
            Console.WriteLine($"O maior número digitado foi {maiorNumero} e o menor foi {menorNumero}");
        }
    }
}
