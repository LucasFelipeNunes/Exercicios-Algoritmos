using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio059
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Os números inteiros compreendidos entre os números digitados são:");
            if(n1 > n2)
            {
                int aux = n2;
                n2 = n1;
                n1 = aux;
            }
            while(n1 < n2 - 1)
            {
                n1++;
                Console.WriteLine(n1);
            }
        }
    }
}
