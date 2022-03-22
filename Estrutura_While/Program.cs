using System;

namespace Estrutura_While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Estrutura While (Enquanto)
             A estrutura Repetitiva While é uma estrutura de controle que repete um bloco de comandos
            enquanto uma condição for verdadeira;

            Quando usar? => quando NÃO se sabe previamente a quantidade de repetiçoes que serão realizadas;

            exemplo:

            Fazer um programa que le numeros inteiros até que um zero seja lido. Ao final, mostrar a soma
            dos numeros lidos;
             */

            Console.Write("Entre com um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            while (n != 0)
            {
                soma += n;
                Console.Write("Entre com um numero inteiro: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
