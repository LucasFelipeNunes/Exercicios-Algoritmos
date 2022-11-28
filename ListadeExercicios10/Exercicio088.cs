using System;
namespace ex73{
    class Program{
        static void Main(string[] args){
            int[] nums = new int[9];
            string par = "";
            string impar = "";
            Console.WriteLine("Digite 10 números: ");
            for(int i=0; i < nums.Length;i++){
                nums[i]= int.Parse(Console.ReadLine());
                if(nums[i] % 2 == 0){
                    par += nums[i] + " ";
                }else{
                    impar += nums[i] + " ";
                }
            }
            Console.WriteLine($"Números pares: {par}");
            Console.WriteLine($"Números ímpares: {impar}");
        }
    }
}
