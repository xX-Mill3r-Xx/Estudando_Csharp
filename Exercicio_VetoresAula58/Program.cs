using System;
using System.Globalization;

namespace Exercicio_VetoresAula58
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa que leia N numeros reais e armazene-os em um vetor. Em seguida:
            - Imprimir todos os elementos do vetor;
            - Mostrar na tela a soma e a media dos elementos do vetor;
             */

            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());
            double[] reais = new double[N];

            Console.Write("Entre com os valores double na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');
            double soma = 0;
            double media = 0.0;

            for(int i = 0; i < N; i++)
            {
                reais[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                soma += double.Parse(vet[i], CultureInfo.InvariantCulture);
                media = soma / N;
            }

            Console.WriteLine();

            for(int i = 0; i<N; i++)
            {
                Console.Write($"{reais[i].ToString("F1", CultureInfo.InvariantCulture)} ");
            }

            Console.WriteLine();

            Console.WriteLine($"A soma dos numeros digitados foi: { soma.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A media dos numeros digitados é de: {media.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
