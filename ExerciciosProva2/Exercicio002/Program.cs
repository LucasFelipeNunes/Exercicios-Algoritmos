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
            int quantidadeDeVogais = 0, quantidadeDeLetrasA = 0, quantidadeDeLetrasE = 0, quantidadeDeLetrasI = 0, quantidadeDeLetrasO = 0, quantidadeDeLetrasU = 0;
            int auxiliar = 0, auxiliar2 = 0;
            string vogaisMaiusculas = "AEIOU", vogaisMinusculas = "aeiou", letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ", letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("Lucas Felipe da Silva Nunes - Matrícula 2211139 - Exercícios 02 e 03");
            Console.Write("Digite uma frase aqui: ");
            string frase = Console.ReadLine();
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'A' || frase[i] == 'a')
                {
                    quantidadeDeLetrasA++;
                }
                else if (frase[i] == 'E' || frase[i] == 'e')
                {
                    quantidadeDeLetrasE++;
                }
                else if (frase[i] == 'I' || frase[i] == 'i')
                {
                    quantidadeDeLetrasI++;
                }
                else if (frase[i] == 'O' || frase[i] == 'o')
                {
                    quantidadeDeLetrasO++;
                }
                else if (frase[i] == 'U' || frase[i] == 'u')
                {
                    quantidadeDeLetrasU++;
                }
            }
            quantidadeDeVogais = quantidadeDeLetrasA + quantidadeDeLetrasE + quantidadeDeLetrasI + quantidadeDeLetrasO + quantidadeDeLetrasU;
            Console.Write($"A frase digitada possui {quantidadeDeVogais} vogais no total\nEla possui {quantidadeDeLetrasA} letras A\nEla possui {quantidadeDeLetrasE} letras E\nEla possui {quantidadeDeLetrasI} letras I\nEla possui {quantidadeDeLetrasO} letras O\nEla possui {quantidadeDeLetrasU} letras U\nA frase digitada, sem espaços, é: ");
            for (int i = 0; i < frase.Length; i++)
            {
                if(frase[i] != ' ')
                {
                    Console.Write(frase[i]);
                }
            }
            Console.Write("\n\nAgora, digite uma letra, vogal ou consoante, para substituir as vogais da frase: ");
            char letra = char.Parse(Console.ReadLine());
            Console.Write($"A frase original era: {frase}\nA frase nova, com as vogais substituídas pela letra {letra}, é: ");
            for(int i = 0;i < frase.Length; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    if(frase[i] == vogaisMaiusculas[j])
                    {
                        for (int k = 0; k < 26; k++)
                        {
                            if (letra == letrasMinusculas[k])
                            {
                                Console.Write(letrasMaiusculas[k]);
                            }
                            else
                            {
                                auxiliar2++;
                            }
                        }
                        if (auxiliar2 == 26)
                        {
                            Console.Write(letra);
                        }
                        
                    }
                    else if(frase[i] == vogaisMinusculas[j])
                    {
                        for (int k = 0; k < 26; k++)
                        {
                            if (letra == letrasMaiusculas[k])
                            {
                                Console.Write(letrasMinusculas[k]);
                            }
                            else
                            {
                                auxiliar2++;
                            }
                        }
                        if (auxiliar2 == 26)
                        {
                            Console.Write(letra);
                        }
                    }
                    else
                    {
                        auxiliar++;
                    }
                }
                if(auxiliar == 5)
                {
                    Console.Write(frase[i]);
                }
                auxiliar = 0;
                auxiliar2 = 0;
            }
            Console.WriteLine();
        }
    }
}
