using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Vetores;
            Um vetor corresponde a uma coleção de dados de tamanho fixo, indexada, unidimensional e homogenea;

            ¹Indexada: Os elementos são acessados por meio de indices;
            
            ²Unidmensional: Uma Dimensão;

            ³Homogenea: Todos os dados são do mesmo tipo

            ##################################################################################################
            Vetores tambem são chamados de arranjos unidimenseionais.

            Em C# a primeira posição em um vetor é a posição 0;

            Um arranjo deve ser alocado previamente, antes de ser utilizado. Uma vez alocado, sua quantidade de 
            elementos é fixa;
             
             */

            //Como criar um vetor;
            //Veja o exemplo;

            //string[] A; // aqui declaramos um vetor de string e damos a ele o nome A
            //A = new string[3]; // Instanciamos este vetor A com o valor de 3 posições;

            //Como acessar um vetor;

            //A[0] = "Nome1"; // isso significa que, o vetor A, na posiçao 0 recebe a string "Nome1";

            /*
             Tambem é possivel preencher um vetor usando a estrutura for();
            veja um exemplo;
             */

            //for(int i = 0; i < 3; i++)
            //{
            //    A[i] = $"Nome {i}";
            //    Console.WriteLine(A[i]);
            //}

            /*
             Para fixar, aqui um problema exemplo;

            Fazer um programa para ler um numero inteiro positivo N, depois ler N numeros quaisquer e armazena-los em um vetor. Em seguida, mostrar na tela todos os elementos do vetor;
             */

            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());
            double[] num = new double[N];

            for(int i = 0; i < N; i++)
            {
                //Este for preenche todo o vetor
                Console.Write("Informe o valor double a ser add: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                num[i] += valor;
            }

            Console.WriteLine();

            for(int i = 0; i < N; i++)
            {
                //Este for serve pra exibir os resultados preenchidos;
                Console.WriteLine($"O numero digitado foi {num[i].ToString("F1", CultureInfo.InvariantCulture)}");
            }

            Console.ReadLine();
        }
    }
}
