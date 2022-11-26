using System;
namespace ex73{
    class Program{
        static void Main(string[] args){
            String maior = "";
            String menor = "";
            int igual = 0;
            Console.Write("Digite um valor fixo: ");
            int[] arr = new int[10];
            int num = int.Parse(Console.ReadLine());
            Console.Write("Digite 10 valores: ");
            for(int i = 0; i <= arr.Length-1; i++){
                arr[i] = int.Parse(Console.ReadLine());
                if(arr[i] > num){
                    maior += arr[i] + " ";
                }else if(arr[i] == num){
                    igual++;
                }else{
                    menor += arr[i] + " ";
                }
            }
            Console.WriteLine($"Numeros maiores que {num}: {maior}\nQuantos iguais a {num}: {igual}" +
            $"\nNumeros menores que {num}: {menor}");
        }
    }
}
