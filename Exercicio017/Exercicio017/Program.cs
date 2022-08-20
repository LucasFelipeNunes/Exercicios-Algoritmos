using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor para a área da base de um prisma: ");
            double areaBase = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor para a altura de um prisma: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"O volume deste prisma é {areaBase * altura}");
        }
    }
}
