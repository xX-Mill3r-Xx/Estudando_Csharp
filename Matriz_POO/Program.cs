using System;

namespace Matriz_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Checklist
                • Revisão do conceito de matriz
                • Declaração e instanciação
                • Acesso aos elementos / como percorrer uma matriz
                • Propriedade Length, Rank e GetLength
                • Referência: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays*/

            /*Matrizes
                • Em programação, "matriz" é o nome dado a arranjos bidimensionais
                • Arranjo é uma estrutura de dados:
                • Homogênea (dados do mesmo tipo)
                • Ordenada (elementos acessados por meio de posições)
                • Alocada de uma vez só, em um bloco contíguo de memória
                • Vantagens: 
                • Acesso imediato aos elementos pela sua posição
                • Desvantagens:
                • Tamanho fixo
                • Dificuldade para se realizar inserções e deleções*/

            double[,] matriz = new double[2, 2];

            Console.WriteLine($"O tamanho desta matris é de {matriz.Length}");
            Console.WriteLine($"o tamanho das linhas e colunas desta matriz é de {matriz.Rank}");
            Console.WriteLine($"A dimensão desta matriz é {matriz.GetLength(0)} linhas {matriz.GetLength(0)} colunas");
            Console.WriteLine($"A segunda dimenção da matriz é {matriz.GetLength(1)}");
        }
    }
}
