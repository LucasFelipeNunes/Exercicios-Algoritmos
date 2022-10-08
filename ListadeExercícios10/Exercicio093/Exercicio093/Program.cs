using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio093
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorNotasMaioresque7 = 0, contadorNotasMenoresque5 = 0;
            Console.Write("Digite a quantidade N de alunos: ");
            int N = int.Parse(Console.ReadLine());
            double[] notaAluno = new double[N];
            for (int auxiliar = 0;auxiliar < N; auxiliar++)
            {
                Console.Write("Digite aqui a nota do " + (auxiliar + 1) + " aluno: ");
                notaAluno[N] = double.Parse(Console.ReadLine());
                if(notaAluno[N] > 7.0)
                {
                    contadorNotasMaioresque7++;
                }
                else if(notaAluno[N] < 5.0)
                {
                    contadorNotasMenoresque5++;
                }
            }
            Console.WriteLine($"O número de alunos com nota maior que 7 é {contadorNotasMaioresque7}");
            if(contadorNotasMenoresque5 > 0)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
            }
        }
    }
}
