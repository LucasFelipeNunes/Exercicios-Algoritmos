using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio070
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            do
            {
                if (numero % 4 != 0)
                {
                    Console.WriteLine("PI");
                }
                else
                {
                    Console.WriteLine(Math.PI);
                }
                numero++;
            } while (numero <= 100);
        }
    }
}
