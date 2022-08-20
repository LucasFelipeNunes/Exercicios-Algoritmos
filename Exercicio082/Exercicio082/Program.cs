using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio082
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            for (int aux = 0; aux < 4; aux++)
            {
                Console.Write($"Digite o {aux + 1}º número: ");
                numero = double.Parse(Console.ReadLine());
                Console.WriteLine($"A raíz cúbica deste número é {Math.Pow(numero, 1.0/3.0)} e este número elevado ao cubo é {Math.Pow(numero, 3)}");
            }
        }
    }
}
