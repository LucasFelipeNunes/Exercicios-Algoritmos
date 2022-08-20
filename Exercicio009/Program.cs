using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio009{
    class Program
    {
        public static void Main(string[] args)
        {
            int comprimento = 5, altura = 3, area = comprimento * altura, perimetro = 2 * (comprimento + altura);
            Console.WriteLine("A área é " + area + " e o perímetro é " + perimetro);
        }
    }
}