using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio106
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            int auxiliar = palavra.Length;
            while(auxiliar > 0)
            {
                Console.Write(palavra[auxiliar - 1]);
                auxiliar--;
            }
            Console.WriteLine();
        }
    }
}
