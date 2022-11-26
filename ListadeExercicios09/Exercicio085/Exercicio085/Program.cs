using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio085
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos números pares serão impressos: ");
            int qtdPares = int.Parse(Console.ReadLine());
            for(int aux = 0;aux < qtdPares; aux++)
            {
                Console.Write((aux + 1) * 2 + " ");
            }
            Console.WriteLine();
        }
    }
}
