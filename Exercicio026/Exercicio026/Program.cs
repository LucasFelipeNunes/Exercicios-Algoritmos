using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio026
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro maior que 0: ");
            int valor = int.Parse(Console.ReadLine());
            if(valor <= 0)
            {
                Console.WriteLine("O valor digitado nao pode ser menor ou igual a 0");
            }
            else{
                if(valor%2 == 0)
                {
                    Console.WriteLine("O valor digitado é par");
                }
                else
                {
                    Console.WriteLine("O valor digitado é ímpar");
                }
            }
        }
    }
}
