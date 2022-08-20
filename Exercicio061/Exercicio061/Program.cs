using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio061
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1000, soma = 0;
            Console.WriteLine("Os números ímpares entre 150 e 1000, em ordem decrescente, são:");
            while (numero > 150)
            {
                if (numero % 2 == 1)
                {
                    Console.WriteLine(numero);
                }
                numero--;
            }
        }
    }
}
