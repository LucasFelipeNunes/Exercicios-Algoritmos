using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio080
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int aux = 1; aux <= 100; aux++)
            {
                Console.WriteLine(aux);
                soma += aux;
            }
            Console.WriteLine("A soma entre estes números é " + soma);
        }
    }
}
