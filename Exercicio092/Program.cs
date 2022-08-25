using System;
namespace ex73{
    class Program{
        static void Main(string[] args){
            Random rnd = new Random();
            int[] arrvf = new int[1];
            String ident = "";

            Console.WriteLine("Digite a quantidade de compenentes da primeira array: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr1 = new int[num];

            Console.WriteLine("Digite a quantidade de compenentes da primeira array: ");
            int num2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[num2];
            for(int i =0; i<=arr1.Length-1; i++){
                arr1[i] = rnd.Next(1,50);
            }
            for(int i =0; i<=arr2.Length-1; i++){
                arr2[i] = rnd.Next(1,50);
            }
            int arrs1 = arr1.Length;
            int arrs2 = arr2.Length;
            for(int i =0; i<=arr1.Length; i++){
                ident += arr1[i] + " ";
            }
            Console.Write($"Os números idênticos foram: {ident}");
        }
    }
}
