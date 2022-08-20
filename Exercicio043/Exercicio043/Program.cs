using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio043
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu peso, em quilogramas: ");
            double peso = double.Parse(Console.ReadLine());
            if(peso <= 0)
            {
                Console.Write("Valor inválido para peso.\n");
            }
            else
            {
                Console.Write("Digite a sua altura, em metros: ");
                double altura = double.Parse(Console.ReadLine());
                if (altura <= 0)
                {
                    Console.Write("Valor inválido para altura.\n");
                }
                else
                {
                    double IMC = peso / Math.Pow(altura, 2);
                    if (IMC < 17)
                    {
                        Console.WriteLine("Esta pessoa está muito abaixo do peso.");
                    }
                    else if (IMC >= 17 && IMC < 18.5)
                    {
                        Console.WriteLine("Esta pessoa está abaixo do peso.");
                    }
                    else if (IMC >= 18.5 && IMC < 25)
                    {
                        Console.WriteLine("Esta pessoa está com peso normal.");
                    }
                    else if (IMC >= 25 && IMC < 30)
                    {
                        Console.WriteLine("Esta pessoa está acima do peso.");
                    }
                    else if (IMC >= 30 && IMC < 35)
                    {
                        Console.WriteLine("Esta pessoa está com obesidade I.");
                    }
                    else if (IMC >= 35 && IMC < 40)
                    {
                        Console.WriteLine("Esta pessoa está com obesidade II (severa).");
                    }
                    else
                    {
                        Console.WriteLine("Esta pessoa está com obesidade III (mórbida).");
                    }
                }
            }
        }
    }
}
