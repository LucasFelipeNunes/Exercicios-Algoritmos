using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio060
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1, soma = 0;
            while(numero < 200)
            {
                if(numero%2 == 1)
                {
                    soma += numero;
                }
                numero++;
            }
            Console.WriteLine($"A soma dos números ímpares entre 1 e 200 é {soma}");
        }
    }
}
