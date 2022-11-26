using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor para o raio da circunferência externa: ");
            double raioExterno = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor para o raio da circunferência interna: ");
            double raioInterno = double.Parse(Console.ReadLine());
            Console.WriteLine($"A área da coroa desta forma circular será {Math.PI * (Math.Pow(raioExterno, 2) - Math.Pow(raioInterno, 2))}");
        }
    }
}
