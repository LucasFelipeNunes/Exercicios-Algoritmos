using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio081
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            for(int aux = 0;aux < 10; aux++)
            {
                Console.Write($"Digite o {aux + 1}º número: ");
                numero = double.Parse(Console.ReadLine());
                Console.WriteLine($"A metade deste número é {numero / 2}");
            }
        }
    }
}
