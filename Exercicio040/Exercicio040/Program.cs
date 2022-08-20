using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual operação você deseja efetuar?\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\nDigite aqui: ");
            string operacao = Console.ReadLine();
            Console.Write("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());
            switch (operacao)
            {
                case "1":
                    Console.WriteLine($"O resultado da soma é {numero1 + numero2}");
                    break;
                case "2":
                    Console.WriteLine($"O resultado da subtração é {numero1 - numero2}");
                    break;
                case "3":
                    Console.WriteLine($"O resultado da multiplicação é {numero1 * numero2}");
                    break;
                case "4":
                    Console.WriteLine($"O resultado da divisão é {numero1 / numero2}");
                    break;
                default:
                    Console.WriteLine("A operação requisitada não existe.");
                    break;
            }
        }
    }
}
