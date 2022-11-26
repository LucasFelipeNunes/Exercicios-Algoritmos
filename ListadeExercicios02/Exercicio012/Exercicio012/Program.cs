using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            Console.Write($"O número digitado foi {numero}\nSua raíz cúbica é {Math.Pow(numero, 1.0/3.0)}\nSua raíz quadrada é {Math.Sqrt(numero)}");
        }
    }
}
