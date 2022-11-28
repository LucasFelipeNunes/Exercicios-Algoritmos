using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio025
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do cateto b de um triângulo retângulo: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do cateto c de um triângulo retângulo: ");
            double c = double.Parse(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow(b,2) + Math.Pow(c,2));
            double area = b * c;
            Console.WriteLine($"A hipotenusa deste triângulo retângulo vale {a} e sua área vale {area}");
        }
    }
}
