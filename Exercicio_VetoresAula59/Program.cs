using System;
using System.Globalization;

namespace Exercicio_VetoresAula59
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um numero N, depois um nome(apenas uma palavra), idade e altura de N pessoas.
            -Mostrar na tela a altura media das pessoas e mostrar tambem a porcentagem de pessoas com menos de 16 anos;
             */

            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());
            string[] nomes = new string[N];
            int[] idade = new int[N];
            double[] altura = new double[N];

            double soma = 0.0;
            double media = 0.0;
            int cont = 0;
            

            for(int i =0; i < N; i++)
            {
                Console.Write("Entre com os dados da pessoa: ");
                string[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
                altura[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
                soma += altura[i];
                media = soma / N;
                if (idade[i] < 16)
                {
                    cont++;
                } 
            }

            double percent = (double)cont / N * 100.0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{nomes[i]} {idade[i]} {altura[i].ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine($"A media da altura entre as pessoas é de {media.ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.WriteLine($"Pessoas com menos de 16 anos {percent.ToString("F1", CultureInfo.InvariantCulture)}%");

            Console.ReadLine();
        }
    }
}
