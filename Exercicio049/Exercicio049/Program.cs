using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio049
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero2 < numero1)
            {
                while (numero2 <= numero1)
                {
                    Console.WriteLine(numero2);
                    numero2++;
                }
            }
            else
            {
                while (numero1 <= numero2)
                {
                    Console.WriteLine(numero1);
                    numero1++;
                }
            }
        }
    }
}
