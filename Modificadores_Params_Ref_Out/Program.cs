using System;

namespace Modificadores_Params_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Suponha que se queira uma calculadora para calcular a soma de uma quantidade 
             variável de valores. Solução ruim usando sobrecarga:
             */

            /*
            class Calculator
            {
                public static int Sum(int n1, int n2)
                {
                    return n1 + n2;
                }
                public static int Sum(int n1, int n2, int n3)
                {
                    return n1 + n2 + n3;
                }
                public static int Sum(int n1, int n2, int n3, int n4)
                {
                    return n1 + n2 + n3 + n4;
                }
            }
            _____________________________________________________________________________________________________________
            */

            //Solução com vetor:

            /*
             class Calculator
            {
                public static int Sum(int[] numbers)
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }
                    return sum;
                }
            }

            int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });
            _____________________________________________________________________________________________________________
            */

            //Solução com modificador params:

            /*
             class Calculator {
                 public static int Sum(params int[] numbers) {
                    int sum = 0;
                    for (int i=0; i<numbers.Length; i++) {
                        sum += numbers[i];
                  }
                   return sum;
                  }
              }

            int result = Calculator.Sum(10, 20, 30, 40);
            _____________________________________________________________________________________________________________
             */

            /*
             Considerações sobre ref e out
                • Diferença:
                • A variável passada como parâmetro ref DEVE ter sido iniciada
                • A variável passada como parâmetro out não precisa ter sido iniciada
                • Conclusão: ambos são muito similares, mas ref é uma forma de fazer 
                o compilador obrigar o usuário a iniciar a variável.
                • Nota: ambos são considerados "code smells" (design ruim) e devem 
                ser evitados.
             */
        }
    }
}
