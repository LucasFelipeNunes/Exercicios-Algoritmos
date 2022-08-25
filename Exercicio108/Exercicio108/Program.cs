using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio108
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdEspacosEmBranco = 0;
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            for(int auxiliar = 0;auxiliar < frase.Length; auxiliar++)
            {
                if(frase[auxiliar] == ' ')
                {
                    qtdEspacosEmBranco++;
                }
            }
            Console.WriteLine("A quantidade de espaços em branco nesta frase é " + qtdEspacosEmBranco);
        }
    }
}
