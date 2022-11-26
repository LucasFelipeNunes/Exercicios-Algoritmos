using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio087
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for(int aux = 25;aux <= 200; aux++)
            {
                soma += aux;
            }
            Console.WriteLine("A soma dos números entre 25 e 200 é " + soma);
        }
    }
}
