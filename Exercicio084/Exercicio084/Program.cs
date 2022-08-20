using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio084
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o limite superior do intervalo: ");
            int limiteSuperior = int.Parse(Console.ReadLine());
            for(int aux = 1;aux < limiteSuperior; aux++)
            {
                if(aux%2 == 1)
                {
                    Console.Write(aux + " ");
                }
            }
        }
    }
}
