using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine($"A raíz quadrada de {numero} é {Math.Sqrt(numero)}");
        }
    }
}
