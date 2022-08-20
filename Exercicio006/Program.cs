using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            double numero1 = double.Parse(Console.ReadLine()), numero2 = double.Parse(Console.ReadLine()), soma = numero1 + numero2, subtracao = numero1 - numero2, multiplicacao = numero1 * numero2, divisao = numero1 / numero2, media = soma / 2;
            Console.WriteLine("Os números digitados foram " + numero1 + " e " + numero2);
            Console.WriteLine("A soma dos números " + numero1 + " e " + numero2 + " é " + soma);
            Console.WriteLine("A subtração dos números " + numero1 + " e " + numero2 + " é " + subtracao);
            Console.WriteLine("A multiplicação dos números " + numero1 + " e " + numero2 + " é " + multiplicacao);
            Console.WriteLine("A divisão dos números " + numero1 + " e " + numero2 + " é " + divisao);
            Console.WriteLine("A média dos números " + numero1 + " e " + numero2 + " é " + media);
        }
    }
}