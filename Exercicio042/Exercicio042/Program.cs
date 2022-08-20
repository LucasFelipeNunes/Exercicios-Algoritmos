using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio042
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a primeira nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());
            if (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("Esta nota é inválida.");
            }
            else
            {
                Console.Write("Digite a segunda nota do aluno: ");
                double nota2 = double.Parse(Console.ReadLine());
                if (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("Esta nota é inválida.");
                }
                else
                {
                    Console.Write($"O nome do(a) aluno(a) é {nome}, suas notas foram {nota1} e {nota2} e sua média foi {(nota1 + nota2) / 2}, o que significa que ele(a) ficou");
                    if(((nota1 + nota2) / 2) > 7)
                    {
                        Console.WriteLine(" aprovado(a).");
                    }
                    else if(((nota1 + nota2) / 2) < 5)
                    {
                        Console.WriteLine(" retido(a).");
                    }
                    else
                    {
                        Console.WriteLine(" de recuperação.");
                    }
                }
            }
        }
    }
}
