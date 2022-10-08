using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio063
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.Write("Digite um valor positivo para o limite superior do intervalo: ");
            int limiteSuperior = int.Parse(Console.ReadLine());
            while (limiteSuperior <= 0)
            {
                Console.Write("Valor inválido (nulo ou negativo). Por favor, digite um valor positivo para o limite superior do intervalo: ");
                limiteSuperior = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite um valor positivo para o incremento do intervalo: ");
            int incremento = int.Parse(Console.ReadLine());
            while (limiteSuperior <= 0)
            {
                Console.Write("Valor inválido (nulo ou negativo). Por favor, digite um valor positivo para o incremento do intervalo: ");
                incremento = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("O intervalo criado tem os seguintes membros, em ordem crescente: ");
            while(numero <= limiteSuperior)
            {
                Console.WriteLine(numero);
                numero += incremento;
            }
        }
    }
}
