using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio096
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            for(int auxiliar = 0;auxiliar < 5; auxiliar++)
            {
                Console.Write($"Digite o {auxiliar + 1}º nome: ");
                nomes[auxiliar] = Console.ReadLine();
            }
            Console.WriteLine("Os nomes na ordem que foram digitados são:");
            for (int auxiliar = 0; auxiliar < 5; auxiliar++)
            {
                Console.WriteLine(nomes[auxiliar]);
            }
            Console.WriteLine("Os nomes na ordem inversa à que foram digitados são:");
            for (int auxiliar = 4; auxiliar >= 0; auxiliar--)
            {
                Console.WriteLine(nomes[auxiliar]);
            }
        }
    }
}
