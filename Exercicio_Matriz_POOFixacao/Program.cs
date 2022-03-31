using System;

namespace Exercicio_Matriz_POOFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Fazer um programa para ler dois números inteiros M e N, e depois ler
                uma matriz de M linhas por N colunas contendo números inteiros,
                podendo haver repetições. Em seguida, ler um número inteiro X que
                pertence à matriz. Para cada ocorrência de X, mostrar os valores à
                esquerda, acima, à direita e abaixo de X, quando houver, conforme
                exemplo.
            */

            int m, n;

            Console.Write("Entre com o valor de M e N: ");
            string[] MN = Console.ReadLine().Split(' ');
            m = int.Parse(MN[0]);
            n = int.Parse(MN[1]);
            int[,] matriz = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                Console.Write($"Entre com os valores da linha #{i}: ");
                string[] num = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(num[j]);
                }
            }

            Console.Write("Entre com o numero que corresponde a X: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matriz[i,j] == x)
                    {
                        Console.WriteLine($"Position: {i}, {j}:");

                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, j - 1]}");
                        }

                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {matriz[i - 1, j]}");
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine($"Right: {matriz[i, j + 1]}");
                        }

                        if (i < m - 1)
                        {
                            Console.WriteLine($"Down: {matriz[i + 1, j]}");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
