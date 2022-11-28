using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio041
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            Console.Write($"O número digitado foi {numero} e ");
            if(numero >= 0)
            {
                Console.WriteLine($"sua raíz quadrada é {Math.Sqrt(numero)}");
            }
            else
            {
                Console.WriteLine($"ele elevado ao quadrado é {Math.Pow(numero, 2)}");
            }
        }
    }
}
