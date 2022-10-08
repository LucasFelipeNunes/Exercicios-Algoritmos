using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio034
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da diagonal menor do losango: ");
            double diagonalMenor = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da diagonal maior do losango: ");
            double diagonalMaior = double.Parse(Console.ReadLine());
            if(diagonalMenor > 0 && diagonalMaior > 0)
            {
                Console.WriteLine($"A área do losango será {diagonalMaior * diagonalMenor / 2}");
            }
            else
            {
                Console.WriteLine("Valores inválidos");
            }
        }
    }
}
