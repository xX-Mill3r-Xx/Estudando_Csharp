using System;

namespace Exercicio_MatrizAula67
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler dois numeros inteiros M e N. Em seguida, ler uma matriz de M
            linhas e N colunas contendo numeros inteiros. Gerar um vetor de modo que cada elemento do vetor
            seja a soma dos elementos da linha correspondente da matriz.
            Mostrar o vetor gerado;
             */

            Console.Write("Entre com a Linha M e a coluna N: ");
            string[] linhaColuna = Console.ReadLine().Split(' ');
            int M = int.Parse(linhaColuna[0]);
            int N = int.Parse(linhaColuna[1]);
            int[,] matriz = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                Console.Write("Entre com os elementos: ");
                string[] vet = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }

            int[] vetor = new int[M];

            for(int i = 0; i < M; i++)
            {
                int soma = 0;
                for(int j = 0; j< N; j++)
                {
                    soma += matriz[i, j];
                }
                vetor[i] = soma;
            }

            for(int i = 0; i < M; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.ReadLine();
        }
    }
}
