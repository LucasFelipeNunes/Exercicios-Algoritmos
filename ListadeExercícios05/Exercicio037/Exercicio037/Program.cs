using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio037
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            double numeroAoQuadrado = Math.Pow(numero, 2);
            Console.Write($"Este número ao quadrado é {numeroAoQuadrado}");
            if(numeroAoQuadrado > 10)
            {
                Console.WriteLine($", e a sua raíz cúbica é {Math.Pow(numeroAoQuadrado, 1.0 / 3.0)}");
            }
            else
            {
                Console.Write("\n");
            }
        }
    }
}
