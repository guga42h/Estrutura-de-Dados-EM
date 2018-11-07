using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD
{
    class Program
    {
        static void Main(string[] args)
        {
            var nd = Console.ReadLine().Split(' ');

            var quantidadeDeValores = Convert.ToInt32(nd[0]);

            var rotacoes = Convert.ToInt32(nd[1]);

            var vetor = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            for(var i = 0; i < rotacoes; i++)
            {
                var primeiroValor = vetor[0];
                for (var j = 0; j < quantidadeDeValores; j++)
                {
                    if (j == (quantidadeDeValores - 1))
                    {
                        vetor[j] = primeiroValor;
                        break;
                    }
                    vetor[j] = vetor[j + 1];
                }
            }
            for (var i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i]} ");
            }
            Console.ReadKey();
        }
    }
}
