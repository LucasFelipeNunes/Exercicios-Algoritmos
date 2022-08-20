using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a primeira nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Insira a segunda nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Insira a terceira nota do aluno: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Insira a quarta nota do aluno: ");
            double nota4 = double.Parse(Console.ReadLine());
            double media = (3 * nota1 + 5 * nota2 + 6 * (nota3 + nota4)) / 20;
            Console.Write($"A média ponderada destas notas é {(3 * nota1 + 5 * nota2 + 6 * (nota3 +nota4)) / 20} e o aluno está ");
            Console.WriteLine((media > 6) ? "aprovado." : "reprovado.");
        }
    }
}
