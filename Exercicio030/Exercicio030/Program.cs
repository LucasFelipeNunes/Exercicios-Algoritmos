using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio030
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de uma temperatura em graus Celsius: ");
            double C = double.Parse(Console.ReadLine());
            Console.WriteLine($"Esta temperatura equivale a {C * 1.8 + 32.0} em graus Farenheit.");
        }
    }
}
