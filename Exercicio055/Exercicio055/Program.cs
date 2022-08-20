using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio055
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDigitado = 1, soma = 0, qtd = 0, media = 0, maiorNumero = 0, menorNumero = 0, somaPares = 0, mediaPares = 0;
            while (numeroDigitado != 0)
            {
                Console.Write("Digite quantos números não nulos você quiser (e quando não quiser digitar mais, digite 0): ");
                numeroDigitado = double.Parse(Console.ReadLine());
                if (numeroDigitado != 0)
                {
                    soma += numeroDigitado;
                    qtd++;
                    if (qtd == 1 || numeroDigitado > maiorNumero)
                    {
                        maiorNumero = numeroDigitado;
                    }
                    if (qtd == 1 || numeroDigitado < menorNumero)
                    {
                        maiorNumero = numeroDigitado;
                    }
                    if (numeroDigitado % 2 == 0)
                    {
                        somaPares += numeroDigitado;
                    }
                }
            }
            media = soma / qtd;
            mediaPares = somaPares / qtd;
            Console.WriteLine($"A soma dos números digitados é {soma}\nA quantidade de números digitados é {qtd}\nA média dos números digitados é {media}\nO maior número digitado é {maiorNumero}\nO menor número digitado é {menorNumero}\nA média dos números pares digitados é {mediaPares}");
        }
    }
}
