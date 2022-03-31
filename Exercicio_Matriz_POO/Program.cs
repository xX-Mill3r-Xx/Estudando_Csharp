using System;

namespace Exercicio_Matriz_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro N e uma matriz de
                ordem N contendo números inteiros. Em seguida, mostrar a diagonal
                principal e a quantidade de valores negativos da matriz.*/

            Console.Write("Entre com o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n,n];

            for(int i = 0; i < n; i++)
            {
                Console.Write($"Entre com o valor {i} que deseja add a matriz na linha {i}: ");
                string[] linha = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Diagonal Numbers: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{matriz[i, i]} ");
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matriz[i,j] < 0)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Negative Numbers: ");
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
