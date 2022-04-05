using System;

namespace Exercicio_Vetores03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3) Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um 
             terceiro vetor C onde cada elemento de C é a soma dos elementos correspondentes de A e B.
             Imprima o vetor C gerado.
            */

            Console.Write("Entre com o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int[] B = new int[n];

            Console.Write("Entre com os valores do vetor A: ");
            string[] vet = Console.ReadLine().Split(' ');

            for(int i = 0; i< n; i++)
            {
                A[i] = int.Parse(vet[i]);
            }

            Console.Write("Entre com os valores do vetor B: ");
            vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                B[i] = int.Parse(vet[i]);
            }

            int[] C = new int[n];
            for (int i = 0; i < n; i++)
            {
                C[i] = A[i] + B[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{C[i]} ");
            }
            Console.ReadLine();
        }
    }
}
