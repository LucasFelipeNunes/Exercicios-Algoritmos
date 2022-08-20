using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio008 {
    class Program {
        public static void Main(string[] args) {
            int lado = 5, area = (int)Math.Pow(lado, 2), perimetro = lado * 4;
            Console.WriteLine("A área é " + area + " e o perímetro é " + perimetro);
        }
    }
}