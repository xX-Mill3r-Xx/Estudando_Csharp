using System;

namespace Estrutura_For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Estrutura Repetitiva For é uma estrutura de controle que repete um bloco de comandos para um certo
            intervalo de valores.

            Quando usar? Quando se sabe previamente a quantidade de repetições ou intervalos de valores;

            Exemplo com exercicio;

            Fazer um programa que le um valor inteiro N e depois N numeros inteiros.
            Ao final, mostrar a soma dos N numeros lidos;
             */

            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for(int i = 1; i <= N; i++)
            {
                Console.Write("Entre com os valores: ");
                int v = int.Parse(Console.ReadLine());
                soma += v;
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
