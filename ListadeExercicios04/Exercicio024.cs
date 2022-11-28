using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do salario minimo: ");
            double salarioMinimo = double.Parse(Console.ReadLine());
            Console.Write("Digite o a quantidade de quilowatts gasta: ");
            double consumo = double.Parse(Console.ReadLine());
            Console.WriteLine($"O valor em reais de cada quilowatt e {salarioMinimo/700}, o valor em reais a ser pago e {salarioMinimo/700 * consumo}, que com um desconto de 10% fica {salarioMinimo/700 * consumo * 0.9}");
        }
    }
}
