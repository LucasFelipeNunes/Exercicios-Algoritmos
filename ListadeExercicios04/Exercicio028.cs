using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio028
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            double n3 = double.Parse(Console.ReadLine());
            double maiorNumero = 0;
            if(n1 > n2)
            {
                if (n3 > n1)
                {
                    maiorNumero = n3;
                }
                else
                {
                    maiorNumero = n1;
                }
            }
            else if (n2 > n1)
            {
                if (n3 > n2)
                {
                    maiorNumero = n3;
                }
                else
                {
                    maiorNumero = n2;
                }
            }
            Console.Write($"Os números digitados foram {n1}, ");
            if(n1 > 0)
            {
                Console.Write($"que e positivo, {n2}, ");
            }
            else if(n1 < 0)
            {
                Console.Write($"que e negativo, {n2}, ");
            }
            else
            {
                Console.Write($"que e nulo, {n2}, ");
            }
            if(n2 > 0)
            {
                Console.Write($"que e positivo, e {n3}, ");
            }
            else if(n2 < 0)
            {
                Console.Write($"que e negativo, e {n3}, ");
            }
            else
            {
                Console.Write($"que e nulo, e {n3}, ");
            }
            if(n3 > 0)
            {
                Console.Write($"que e positivo, sendo o maior deles {maiorNumero}");
            }
            else if(n3 < 0)
            {
                Console.Write($"que e negativo, sendo o maior deles {maiorNumero}");
            }
            else
            {
                Console.Write($"que e nulo, sendo o maior deles {maiorNumero}");
            }
        }
    }
}
