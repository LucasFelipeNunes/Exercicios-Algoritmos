using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio027
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            if((Math.Pow(numero,4))%2 == 0 && (Math.Pow(numero, 4))%5 == 0)
            {
                Console.WriteLine($"O número digitado foi {numero}\nSeu valor elevado ao quadrado é {Math.Pow(numero, 2)}\nSeu valor elevado ao cubo é {Math.Pow(numero, 3)}\nSeu valor elevado a sétima é {Math.Pow(numero, 7)}");
            }
            else if((Math.Pow(numero, 4))%2 == 1)
            {
                Console.WriteLine($"O número digitado foi {numero}\nSua raíz quadrada é {Math.Sqrt(numero)}\nSua raíz cúbica é {Math.Pow(numero, 1.0/3.0)}\nSua raíz a sétima é {Math.Pow(numero, 1.0/7.0)}");
            }
            else
            {
                Console.WriteLine("O valor digitado é inválido ou não cumpre a nenhuma das condições");
            }
        }
    }
}
