using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            double numero1 = double.Parse(Console.ReadLine()),numero2 = double.Parse(Console.ReadLine()), numero3 = double.Parse(Console.ReadLine()), numero4 = double.Parse(Console.ReadLine()), numero5 = double.Parse(Console.ReadLine()), soma = numero1 + numero2 + numero3 + numero4 + numero5;
            Console.WriteLine("Os números digitados foram " + numero1 + ", " + numero2 + ", " + numero3 + ", " + numero4 + " e " + numero5 + " e sua soma é " + soma);
        }
    }
}