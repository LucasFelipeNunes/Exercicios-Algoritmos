using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio048
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro memnor que 10: ");
            int numeroDigitado = int.Parse(Console.ReadLine());
            while (numeroDigitado >= 10)
            {
                Console.Write("O número tem que ser menor que 10, por favor digite outro número: ");
                numeroDigitado = int.Parse(Console.ReadLine());
            }
            int numeroImpresso = 20;
            while (numeroImpresso >= numeroDigitado)
            {
                Console.WriteLine(numeroImpresso);
                numeroImpresso--;
            }
        }
    }
}
