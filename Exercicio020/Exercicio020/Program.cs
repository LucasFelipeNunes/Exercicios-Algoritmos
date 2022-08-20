using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine($"A área da esfera é {4 * Math.PI * Math.Pow(raio, 2)} e o seu volume é {4.0/3.0 * Math.PI * Math.Pow(raio, 3)}");
        }
    }
}
