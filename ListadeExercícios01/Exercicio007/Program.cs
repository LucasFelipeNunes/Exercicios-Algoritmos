using System;

namespace Exercicio007 {
    class Program {
        public static void Main(string[] args) {
            int numero = int.Parse(Console.ReadLine()), antecessor = numero - 1, sucessor = numero + 1;
            Console.WriteLine("O numero digitado foi " + numero + ", seu antecessor é " + antecessor + " e seu sucessor é " + sucessor);
        }
    }
}