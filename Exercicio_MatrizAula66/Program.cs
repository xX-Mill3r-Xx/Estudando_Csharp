using System;

namespace Exercicio_MatrizAula66
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um numero inteiro N e uma matriz quadrada de ordem N contendo numeros inteiros.
            Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz;
             */

            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            int[,] matQ = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matQ[i, j] = int.Parse(vet[j]);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matQ[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Diagonal Principal");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{matQ[i, i]} ");
            }

            int contagem = 0;
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matQ[i, j] < 0)
                    {
                        contagem++;
                    }
                }
            }
            Console.Write($"Quantidade de numeros negativos: {contagem}");
            Console.ReadLine();
        }
    }
}
