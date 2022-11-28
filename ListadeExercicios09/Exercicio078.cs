using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio078
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int aux = 1; aux <= 600; aux++)
            {
                if(aux%2 == 0)
                {
                    Console.WriteLine(aux);
                }
            }
        }
    }
}
