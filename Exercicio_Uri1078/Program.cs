using System;

namespace Exercicio_Uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia um valor inteiro N(2<N<1000), A seguir, mostre a tabuada de N:
            1 x N = N, 2 x N = 2N ...
             */

            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i < N; i++)
            {
                int result = i * N;
                Console.WriteLine($"{i} * {N} = {result}");
            }

            Console.ReadLine();
        }
    }
}
