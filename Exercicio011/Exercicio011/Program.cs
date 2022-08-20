using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine($"O número digitado foi {numero}, e seu valor elevado a 2 é {Math.Pow(numero,2)}, elevado a 3 é {Math.Pow(numero,3)}, elevado a 4 é {Math.Pow(numero, 4)} e elevado a 5 é {Math.Pow(numero,5)}");
        }
    }
}
