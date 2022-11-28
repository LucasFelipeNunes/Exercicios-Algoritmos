using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio045
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o código do item: ");
            string codigo = Console.ReadLine();
            if(codigo != "100" && codigo != "101" && codigo != "102" && codigo != "103" && codigo != "104")
            {
                Console.WriteLine("Não existe nenhum produto com este código.");
            }
            else
            {
                Console.Write("Digite a quantidade deste item que será pedida: ");
                int qtd = int.Parse(Console.ReadLine());
                if(qtd <= 0)
                {
                    Console.WriteLine("Quantidade inválida.");
                }
                else
                {
                    switch (codigo)
                    {
                        case "100":
                            Console.WriteLine($"O valor a ser pago é {4.5 * qtd}");
                            break;
                        case "101":
                            Console.WriteLine($"O valor a ser pago é {4.5 * qtd}");
                            break;
                        case "102":
                            Console.WriteLine($"O valor a ser pago é {5.5 * qtd}");
                            break;
                        case "103":
                            Console.WriteLine($"O valor a ser pago é {6.5 * qtd}");
                            break;
                        case "104":
                            Console.WriteLine($"O valor a ser pago é {3.5 * qtd}");
                            break;
                    }
                }
            }
        }
    }
}
