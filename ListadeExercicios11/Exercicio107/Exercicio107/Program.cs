using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio107
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arrTemVogais = false;
            string vogais = "aeiouAEIOUÁÉÍÓÚáéíóúãõâêîôûàèìòù";
            Console.Write("Digite uma string: ");
            string arr = Console.ReadLine();
            Console.Write("A string, sem as suas vogais, é: ");
            for(int auxiliar = 0;auxiliar < arr.Length; auxiliar++)
            {
                arrTemVogais = false;
                for(int auxiliar2 = 0;auxiliar2 < vogais.Length;auxiliar2++)
                {
                    if(arr[auxiliar] == vogais[auxiliar2])
                    {
                        arrTemVogais = true;
                    }
                }
                if(arrTemVogais == false)
                {
                    Console.Write(arr[auxiliar]);
                }
            }
            Console.WriteLine();
        }
    }
}
