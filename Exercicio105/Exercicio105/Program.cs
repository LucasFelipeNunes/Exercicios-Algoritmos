using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string palavra = Console.ReadLine();
            Console.WriteLine($"Esta string tem {palavra.Length} letras.");
        }
    }
}
