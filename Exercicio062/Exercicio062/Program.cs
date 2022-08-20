using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio062
{
    class Program
    {
        static void Main(string[] args)
        {
            int polegada = 1;
            Console.Write("Tabela de Conversão de Polegadas para Milímetros (entre 1 e 20 polegadas inteiras)\nPolegadas\tMilímetros\n");
            while(polegada <= 20)
            {
                Console.WriteLine(polegada + " pol\t\t" + (polegada * 25.4) + " mm");
                polegada++;
            }
        }
    }
}
