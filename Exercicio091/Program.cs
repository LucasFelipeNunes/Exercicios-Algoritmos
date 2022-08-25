using System;
namespace ex73{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Digite nome e idade de 6 candidatas: ");
            String[] arran = new String[5];
            int[] arrav = new int[5];
            String aptas = "";
            for(int i =0; i<=arrav.Length-1; i++){
                Console.WriteLine("Digite o nome: ");
                arran[i] = Console.ReadLine();
                Console.WriteLine("Digite a idade: ");
                arrav[i] = int.Parse(Console.ReadLine());
                if(arrav[i] < 18 || arrav[i] >20){
                    aptas += arran[i] + ", ";
                }
            }
            Console.WriteLine($"Candidatas aptas: {aptas} ");
        }
    }
}
