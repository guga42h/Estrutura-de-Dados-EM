using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nd = Console.ReadLine().Split(' ');

            var quantidadeDeValores = Convert.ToInt32(nd[0]);

            var rotacoes = Convert.ToInt32(nd[1]);

            var vetor = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            FormateVetor(quantidadeDeValores, rotacoes, vetor);

            for (var i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i]} ");
            }
            Console.ReadKey();
        }

        private static void FormateVetor(int quantidadeDeValores, int rotacoes, int[] vetor)
        {
            var indiceLimite = quantidadeDeValores % rotacoes;
            var j = 0;
            for (var i = indiceLimite; i < quantidadeDeValores; i++)
            {
                vetor[i] = vetor[j];
                j++;
            }

            for (var i = 0; i < indiceLimite; i++)
            {
                vetor[i] = vetor[j];
                j++;
            }
        }
    }
}
