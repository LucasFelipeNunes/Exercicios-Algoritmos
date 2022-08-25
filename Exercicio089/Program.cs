using System;
namespace ex73{
    class Program{
        static void Main(string[] args){
            Console.Write("Digite o tamanho da array: ");
            int tam = int.Parse(Console.ReadLine());

            int[] arr = new int[tam];

            for(int i=0; i < arr.Length; i++){
                Console.Write("Digite um número: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i=arr.Length-1; i >= 0; i--){
                Console.Write(arr[i] + " | ");
            }
        }
    }
}
