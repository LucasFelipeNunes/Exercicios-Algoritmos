using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio033
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura do degrau da escada, em centímetros: ");
            double alturaDegrau = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura que você deseja atingir subindo a escada, em centímetros: ");
            double alturaDesejada = double.Parse(Console.ReadLine());
            if(alturaDegrau > 18)
            {
                Console.WriteLine("A altura do degrau não está conforme as normas");
            }
            else if(alturaDegrau <= 0 || alturaDesejada <= 0)
            {
                Console.WriteLine("A altura digitada para o degrau ou para ser atingida é inválida");
            }
            else
            {
                Console.WriteLine($"Desconsiderando sua altura, o número de degraus que você deve subir para atingir esta altura é {Math.Round(alturaDesejada / alturaDegrau) + 1}");
            }
        }
    }
}
