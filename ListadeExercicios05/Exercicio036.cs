using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio036
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do produto: ");
            double valor = double.Parse(Console.ReadLine());
            if(valor <= 0)
            {
                Console.WriteLine("Este valor é inválido");
            }
            else
            {
                Console.WriteLine($"Com um desconto de 9%, o novo valor deste produto é {0.91 * valor}");
            }
        }
    }
}
