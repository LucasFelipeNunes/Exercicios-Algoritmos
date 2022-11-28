using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio071
{
    class Program
    {
        static void Main(string[] args)
        {
            int auxiliar = 0;
            double numero;
            do
            {
                Console.Write($"Digite o {auxiliar + 1}º número: ");
                numero = double.Parse(Console.ReadLine());
                auxiliar++;
                Console.WriteLine($"A metade deste número é {numero / 2}");
            } while (auxiliar <= 9);
        }
    }
}
