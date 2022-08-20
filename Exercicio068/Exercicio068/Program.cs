using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio068
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo = "";
            double pesoIdeal = 0;
            Console.Write("Digite a altura da pessoa em questão, em metros: ");
            double h = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("Digite o sexo da pessoa em questão (M ou F): ");
                sexo = Console.ReadLine();
            } while (sexo != "F" && sexo != "M");
            if(sexo == "M")
            {
                pesoIdeal = 72.7 * h - 58;
            }
            else if (sexo == "F")
            {
                pesoIdeal = 62.1 * h - 44.7;
            }
            Console.WriteLine($"O peso ideal desta pessoa é {pesoIdeal}");
        }
    }
}
