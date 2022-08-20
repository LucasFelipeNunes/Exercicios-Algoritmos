using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio032
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"Após um aumento de 25%, o salário do funcionário será {1.25 * salario}");
        }
    }
}
