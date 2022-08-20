using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio058
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 300;
            Console.WriteLine("Os números múltiplos de 3 e 5 entre 300 e 30, em ordem descrescente, são:");
            while(numero > 30)
            {
                if(numero%3 == 0 && numero % 5 == 0)
                {
                    Console.WriteLine(numero);
                }
                numero--;
            }
        }
    }
}
