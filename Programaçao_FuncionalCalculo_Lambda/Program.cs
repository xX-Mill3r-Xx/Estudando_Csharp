using System;
using System.Collections.Generic;

namespace Programaçao_FuncionalCalculo_Lambda
{
    class Program
    {
        #region Variavel Global
        public static int globalValue = 3;
        #endregion

        #region Objetos de primeira classe
        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
        #endregion

        static void Main(string[] args)
        {
            /*
             Paradigmas de programação
                • Imperativo (C, Pascal, Fortran, Cobol)
                • Orientado a objetos (C++, Object Pascal, Java (< 8), C# (< 3)) 
                • Funcional (Haskell, Closure, Clean, Erlang)
                • Lógico (Prolog)
                • Multiparadigma (JavaScript, Java (8+), C# (3+), Ruby, Python, Go)

            Transferencia referencial;

            Uma função possui tranparencia referencial se seu resultado for o mesmo para os mesmos dados de entrada.
             - Beneficios: Simplicidade e previsibilidade;
             */

            #region Exemplo
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));
            #endregion

            /*
             Funçoes são objetos de primeira ordem (ou primeira classe)
             - Isso significa que funçoes podem, por exemplo, serem passados como parametro de metodos, bem como retornado como resultado de metodos.
             */

            #region Exemplo
            //List<Product> list = new List<Product>();
            //list.Add(new Product("TV", 900.00));
            //list.Add(new Product("Notebook", 1200.00));
            //list.Add(new Product("Tablet", 450.00));
            //list.Sort(CompareProducts);
            #endregion

            /*
             Expressividade / "como" vs. "o quê"

                int sum = 0;
                foreach (int x in list) {
                     sum += x;
                }

                vs.

                int sum = list.Aggregate(0, (x, y) => x + y);

            ###################################################################################################################

            O que são "expressões lambda"?
                Em programação funcional, expressão lambda corresponde a uma função anônima de primeira classe.

                  Cálculo Lambda = formalismo matemático base da programação funcional
                  Expressão lambda = função anônima de primeira classe
             */
        }

        /* Exemplo de função que não é referencialmente transparente*/
        #region Função
        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }
        #endregion
    }
}
