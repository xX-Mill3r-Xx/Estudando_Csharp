using System;
using System.Globalization;

namespace Vetores_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Checklist
                • Revisão do conceito de vetor
                • Manipulação de vetor de elementos tipo structs
                • Manipulação de vetor de elementos tipo classe
                • Acesso aos elementos
                • Propriedade Length

            Vetores
                • Em programação, "vetor" é o nome dado a arranjos unidimensionais

                • Arranjo é uma estrutura de dados:
                • Homogênea (dados do mesmo tipo)
                • Ordenada (elementos acessados por meio de posições)
                • Alocada de uma vez só, em um bloco contíguo de memória

                • Vantagens: 
                • Acesso imediato aos elementos pela sua posição
                • Desvantagens:
                • Tamanho fixo
                • Dificuldade para se realizar inserções e deleções
             */

            /*
             Exercicio Exemplo:

            Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
            pessoas.
             */

            Console.Write("Entre com o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Entre com a idade da pessoa {i}: ");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine();
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Altura da pessoa {i} = " +
                    $"{vet[i].ToString("F2", CultureInfo.InvariantCulture)}");
                sum += vet[i];
                Console.WriteLine();
            }

            double media = sum / n;
            Console.WriteLine($"Altura media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }
}
