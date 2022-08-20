using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o raio da base do cilindro: ");
            double raio = double.Parse(Console.ReadLine());
            Console.Write("Insira a altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"A área da base é {Math.PI * Math.Pow(raio, 2)} e o volume é {Math.PI * Math.Pow(raio, 2) * altura}");
        }
    }
}
