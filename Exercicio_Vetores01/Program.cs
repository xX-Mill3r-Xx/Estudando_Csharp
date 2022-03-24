using System;
using System.Globalization;

namespace Exercicio_Vetores01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Seção: Vetores
               Exercícios propostos
             * 
             1) Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número 
                do vetor (supor não haver empates). Mostrar também a posição do maior elemento.
             */
            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());
            double[] reais = new double[N];
            Console.Write("Entre com os valores reais na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                reais[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            double maior = reais[0];
            int position = 0;
            Console.WriteLine();

            for (int i = 1; i <N; i++)
            {
                if(reais[i] > maior)
                {
                    maior = reais[i];
                    position = i;
                }
            }

            Console.WriteLine($"O maior numero digitado foi {maior.ToString("F1",CultureInfo.InvariantCulture)}, e esta no indice {position}");

            Console.ReadLine();
        }
    }
}
