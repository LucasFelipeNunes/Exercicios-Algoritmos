using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quatro números: ");
            double numero1 = double.Parse(Console.ReadLine()), numero2 = double.Parse(Console.ReadLine()), numero3 = double.Parse(Console.ReadLine()), numero4 = double.Parse(Console.ReadLine()), media = (numero1 + 2 * numero2 + 3 * numero3 + 4 * numero4)/10;
            Console.WriteLine($"A média ponderada destes números é {media}");

        }
    }
}
