using System;

namespace Exercicio_Vetores02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             2) Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
                - todos os números pares
                - a quantidade de números pares
             */

            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());
            int[] vetor = new int[N];

            Console.Write("Entre com os valores na mesma linha: ");
            string[] numeros = Console.ReadLine().Split(' ');

            int numerosPares = 0;
            for(int i = 0; i < N; i++)
            {
                vetor[i] = int.Parse(numeros[i]);
                if(vetor[i] % 2 == 0)
                {
                    Console.Write($"{vetor[i]} ");
                    numerosPares++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(numerosPares);
            Console.ReadLine();            
        }
    }
}
