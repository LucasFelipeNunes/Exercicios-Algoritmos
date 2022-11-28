using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio065
{
    class Program
    {
        static void Main(string[] args)
        {
            double nivelAlerta = 0;
            do
            {
                Console.Write("Digite o número, entre 0 a 10, do nível de alerta: ");
                nivelAlerta = double.Parse(Console.ReadLine());
                if(nivelAlerta < 0 || nivelAlerta > 10)
                {
                    Console.Write("Número inválido. ");
                }
            }
            while (nivelAlerta < 0 || nivelAlerta > 10);
            if(nivelAlerta > 9)
            {
                Console.WriteLine("O nível do risco é GRAVE.");
            }
            else
            {
                Console.WriteLine("O nível do risco não é grave.");
            }
        }
    }
}
