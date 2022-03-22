using System;

namespace Exercicio_Uri1001
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercicio 1001 Uri Online Judge
            Enunciado:

            Leia dois valores inteiros e armazene-os nas variaveis A e B. efetue a soma de A e B atribuindo o seu
            resultado na variavel X. Imprima X conforme exemplo apresentado.

             */

            int A, B, X;

            Console.Write("Entre com o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Entre com o valor de B: ");
            B = int.Parse(Console.ReadLine());

            X = A + B;
            Console.WriteLine($"X = {X}");

            Console.ReadLine();
        }
    }
}
