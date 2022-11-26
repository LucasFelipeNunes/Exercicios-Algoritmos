using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio086
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o limite superior: ");
            int limiteSuperior = int.Parse(Console.ReadLine());
            for (int aux = 1; aux <= limiteSuperior; aux++)
            {
                Console.Write(aux + " ");
            }
            Console.WriteLine();
        }
    }
}
