using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio069
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            do
            {
                if (numero % 2 == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("dos");
                }
                numero++;
            } while (numero <= 100);
        }
    }
}
