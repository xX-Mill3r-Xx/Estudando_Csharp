using System;

namespace Exercicio_VetoresAula57
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa que leia N numeros inteiros e armazene-os em um vetor. Em seguida, mostrar na tela
            todos os numeros negativos lidos;
             */

            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());
            int[] valores = new int[N];

            Console.Write("Entre com um valor int a ser add no vetor: Obs.: Na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                valores[i] = int.Parse(vet[i]);
            }

            Console.WriteLine();

            for(int i = 0; i < N; i++)
            {
                if(valores[i] < 0)
                {
                    Console.WriteLine($"O numero negativo digitado foi: {valores[i]}");
                }
            }

            Console.ReadLine();
        }
    }
}
