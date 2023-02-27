using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lucas Felipe da Silva Nunes - Matrícula 2211139 - Exercício 02");
            int numeroImpresso = 10;
            Console.Write("Digite um valor maior que 10 para o limite superior do intervalo: ");
            int limiteSuperior = int.Parse(Console.ReadLine());
            while (limiteSuperior <= 10)
            {
                Console.Write("O valor digitado foi menor ou igual a 10. Por favor, digite um valor positivo para o limite superior do intervalo: ");
                limiteSuperior = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite um valor positivo para o incremento do intervalo: ");
            int incremento = int.Parse(Console.ReadLine());
            while (incremento <= 0)
            {
                Console.Write("O valor digitado foi nulo ou negativo. Por favor, digite um valor positivo para o incremento do intervalo: ");
                incremento = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("O intervalo criado tem os seguintes membros, em ordem crescente e começando pelo número 10: ");
            while (numeroImpresso <= limiteSuperior)
            {
                if (numeroImpresso != 10)
                {
                    Console.Write(", ");
                }
                Console.Write(numeroImpresso);
                numeroImpresso += incremento;
            }
            Console.Write("\n");
        }
    }
}
