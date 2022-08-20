using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio004
{
    class Program
    {
        static void Main(string[] args)
        {
            int variavel1 = 30, variavel2 = 40;
            Console.WriteLine("A primeira variavel e " + variavel1 + " e a segunda e " + variavel2);
            variavel1 += 1;
            variavel2 -= 1;
            Console.WriteLine("A primeira variavel, acrescida de uma unidade, e " + variavel1 + " e a segunda, decrescida de uma unidade, e " + variavel2);
            Console.Read();
        }
    }
}
