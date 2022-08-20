using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de raio para um círculo: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine($"A área deste círculo é {Math.PI * Math.Pow(raio,2)} e o perímetro é {2 * Math.PI * raio}");
        }
    }
}
