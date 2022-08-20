using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio035
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
                Console.WriteLine($"O valor do lado deste losango é {Math.Sqrt(Math.Pow(diagonalMenor/2, 2) + Math.Pow(diagonalMaior/2.0, 2))}");
            }
            else
            {
                Console.WriteLine("Um ou mais valores são inválidos");
            }
        }
    }
}
