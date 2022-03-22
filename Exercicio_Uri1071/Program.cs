using System;

namespace Exercicio_Uri1071
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia dois valores inteiros X e Y. A seguir, calcule e mostre a soma dos numeros impares entre eles;
             */

            int X, Y, min, max, soma;
            Console.Write("Entre com o valor de X: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Entre com o valor de Y: ");
            Y = int.Parse(Console.ReadLine());

            if(X < Y)
            {
                min = X;
                max = Y;
            }
            else
            {
                min = Y;
                max = X;
            }

            soma = 0;
            for(int i = min+1; i < max; i++)
            {
                if(i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
