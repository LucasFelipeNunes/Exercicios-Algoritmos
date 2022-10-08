using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());
            Console.Write("Insira o terceiro número: ");
            double numero3 = double.Parse(Console.ReadLine());
            double media = (numero1 + numero2 + numero3) / 3;
            Console.WriteLine((media >= 7.5) ? $"A média aritmética destas notas é {media} e o aluno está aprovado." : $"A média aritmética destas notas é {media} e o aluno está reprovado.");
        }
    }
}
