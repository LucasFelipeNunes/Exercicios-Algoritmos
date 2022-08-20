using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine((numero % 2 == 0) ? $"O número {numero} é par, e o seu valor ao quadrado é {Math.Pow(numero, 2)}" : $"O número {numero} é ímpar, e o seu valor ao cubo é {Math.Pow(numero, 3)}");
        }
    }
}
