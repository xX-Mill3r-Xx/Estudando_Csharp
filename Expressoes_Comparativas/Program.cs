using System;

namespace Expressoes_Comparativas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expressoes comparativas são aquelas que comparam uma com a outra;
            //geram um valor verdadeiro ou falso;

            /*
             Operadores de comparação em C#
                    > Maior
                    < Menor
                    >= Maior ou igual
                    <= Menor ou igual
                    == Igual
                    != Diferente
             */

            //exemplos;

            //suponha que x = 5;
            int x = 5;
            bool v = x > 0; // verdadeiro;
            Console.WriteLine($"O resultado é: {v}");
            Console.ReadLine();
        }
    }
}
