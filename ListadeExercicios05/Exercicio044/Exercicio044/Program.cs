using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio044
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de picolés comprados: ");
            int qtd = int.Parse(Console.ReadLine());
            if (qtd <= 0)
            {
                Console.WriteLine("Quantidade inválida.");
            }
            else
            {
                Console.Write("Digite o tipo de picolé que você deseja comprar (1, 2 ou 3): ");
                string tipo = Console.ReadLine();
                if (tipo != "1" && tipo != "2" && tipo != "3")
                {
                    Console.WriteLine("Tipo inválido.");
                }
                else
                {
                    switch (tipo)
                    {
                        case "1":
                            Console.WriteLine($"A quantidade de picolés comprada é {qtd}, e seu tipo é o 1, cujo preço é R$1,50, de forma que o total arrecadado é {1.5 * qtd} reais");
                            break;
                        case "2":
                            Console.WriteLine($"A quantidade de picolés comprada é {qtd}, e seu tipo é o 2, cujo preço é R$2,60, de forma que o total arrecadado é {2.6 * qtd} reais");
                            break;
                        case "3":
                            Console.WriteLine($"A quantidade de picolés comprada é {qtd}, e seu tipo é o 3, cujo preço é R$3,75, de forma que o total arrecadado é {3.75 * qtd} reais");
                            break;
                    }
                }
            }
        }
    }
}
