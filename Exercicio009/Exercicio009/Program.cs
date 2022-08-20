using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor referente a base do retângulo: ");
            double comprimento = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor referente a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());
            double area = comprimento * altura;
            double perimetro = 2 * (comprimento + altura);
            Console.WriteLine($"Área: {area}\nPerímetro: {perimetro}");
        }
    }
}
