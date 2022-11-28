using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio057
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1, soma = 0, qtd = 0;
            while (numero < 100)
            {
                if(numero%2 == 0 && numero % 5 == 0 && numero % 7 == 0)
                {
                    qtd++;
                    Console.WriteLine($"O {qtd}º número encontrado foi {numero}");
                    soma += numero;
                }
                numero++;
            }
            Console.WriteLine($"A soma destes números é {soma}");
        }
    }
}
