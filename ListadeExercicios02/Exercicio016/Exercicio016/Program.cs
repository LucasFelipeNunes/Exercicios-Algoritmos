using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da base maior do trapézio: ");
            double baseMaior = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da base menor do trapézio: ");
            double baseMenor = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do trapézio: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"A área deste trapézio é {((baseMaior + baseMenor) * altura) / 2}");
        }
    }
}
