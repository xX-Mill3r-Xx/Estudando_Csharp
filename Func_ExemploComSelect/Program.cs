using System;
using System.Collections.Generic;
using System.Linq; //Importação
using Entities;

namespace Func_ExemploComSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Func (System)
                • Representa um método que recebe zero ou mais argumentos, e retorna um valor
                • https://msdn.microsoft.com/en-us/library/bb534960%28v=vs.110%29.aspx

                    public delegate TResult Func<out TResult>();
                    public delegate TResult Func<in T, out TResult>(T obj);
                    public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
                    public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 
                    arg2, T3 arg3);
                    (16 sobrecargas)

            Problema exemplo
                Fazer um programa que, a partir de uma lista de produtos, gere uma nova lista contendo os nomes dos produtos em caixa alta.
             */

            #region Exemplo
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);

            }
            #endregion

            /*
             Nota sobre a função Select
                • A função "Select" (pertencente ao LINQ) é uma função que aplica uma função a todos elementos de uma coleção, gerando assim uma nova coleção (do tipo IEnumerable).
             */

            #region Exemplo Select
            List<int> numbers = new List<int> { 2, 3, 4 };
            IEnumerable<int> newList = numbers.Select(x => 2 * x);
            Console.WriteLine(string.Join(" ", newList));
            #endregion
        }
    }
}
