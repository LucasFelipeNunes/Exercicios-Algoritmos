using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio046
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Qual o tipo de média que você deseja fazer?\n1 - aritmética\n2 - ponderada (pesos 3, 3, 4)\nDigite aqui: ");
            string tipo = Console.ReadLine();
            switch (tipo)
            {
                case "1":
                    Console.WriteLine($"A média aritmética entre as três notas é {(nota1 + nota2 + nota3) / 3}");
                    break;
                case "2":
                    Console.WriteLine($"A média aritmética entre as três notas é {(3 * nota1 + 3 * nota2 + 4 * nota3) / 10}");
                    break;
                default:
                    Console.WriteLine("Código inválido para a média");
                    break;
            }
        }
    }
}
