using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor para o lado A de um paralelepípedo: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor para o lado B de um paralelepípedo: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor para o lado C de um paralelepípedo: ");
            double C = double.Parse(Console.ReadLine());
            Console.WriteLine($"O volume deste paralelepípedo é {A * B * C}");
        }
    }
}
