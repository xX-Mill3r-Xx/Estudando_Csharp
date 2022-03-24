using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Uma matriz corresponde a uma coleçao de dados de tamanho fixo, indexada, bidimensional e homogenea;

            ¹Indexada - os elementos são acessados por meio de indices;

            ² bidimensional - duas dimensões;

            ³ Homogenea - todos os dados são do mesmo tipo;
             */

            /*
             Matrizes tambem são chamadas de arranjos bidimensionais
            em C# a primeira posição em um matriz é a posição 0,0 (linha 0, coluna 0);

            Um arranjo bidimensional deve ser alocado previamente antes de ser utilizado. Uma vez alocado, sua quantidade de elementos é fixa;
             */

            /*
            Sintaxe para se declarar uma matriz:

            double[,] A;

            no exemplo acima, declaramos uma matriz do tipo double e demos a ela o nome de A; Note que, difrente
            dos vetores, uma matriz possui uma virgula separando os couchetes, o que significa que ela tem duas dimensoes;

            Para instanciar a matriz fazemos da seguinte forma:

            A = new double[3, 4];

            isso siguinifica que a matriz vai ter o total de 3 linhas e 4 colunas;

            Para acessar o elemento de uma matriz

            A[1,2] = 10;

            isso siguinifica que , na matriz A, o elemento que esta na linha 1 e na coluna 2 ira receber o valor de 10;

            ############################################################################################################

            Problema Exemlo:

            Fazer um programa para ler dois numeros inteiros positivos M e N, depois ler uma matriz de M linhas e N colunas contendo numeros inteiros. Em seguida, mostrar na tela a matriz lida;
            */

            Console.Write("Entre com o valor de (M Linhas) e (N Colunas): ");
            string[] linhaColuna = Console.ReadLine().Split(' ');
            int M = int.Parse(linhaColuna[0]);
            int N = int.Parse(linhaColuna[1]);
            int[,] mat = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                Console.Write($"Entre com os valores da linha M no indice {i}: ");
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    /* Aqui indicamos que, pra cada passagem do for, a matriz mat na linha i coluna j vai receber
                     o que for digitado em vet na coluna j*/
                    mat[i, j] = int.Parse(vet[j]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
