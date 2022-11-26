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
            Console.Write("Digite um número inteiro maior que 0: ");
            int numeroDigitado = int.Parse(Console.ReadLine());
            while(numeroDigitado <= 0)
            {
                Console.Write("O número tem que ser maior que 0, por favor digite outro número: ");
                numeroDigitado = int.Parse(Console.ReadLine());
            }
            int numeroImpresso = 0;
            while(numeroImpresso <= numeroDigitado)
            {
                Console.WriteLine(numeroImpresso);
                numeroImpresso++;
            }
        }
    }
}
