using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio104_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string palavra = Console.ReadLine();
            for(int auxiliar = 0;auxiliar < palavra.Length; auxiliar++)
            {
                if (auxiliar == 0)
                {
                    Console.Write(palavra[auxiliar]);
                }
                else
                {
                    Console.Write("-" + palavra[auxiliar]);
                }
            }
            Console.WriteLine();
        }
    }
}
