using System;
using System.Collections.Generic;
using System.Globalization;
using Entities;
using Services;

namespace FuncoesQueRecebemFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Recordando
                • removeAll(Predicate)
                • ForEach(Action)
                • Select(Func)

            Problema exemplo
                Fazer um programa que, a partir de uma lista de produtos, calcule a soma dos preços somente dos produtos cujo nome começa com "T".

            deve-se obter o valor 1250.50
             */

            #region Exemplo
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            ProductService ps = new ProductService();

            double sum = ps.FilteredSum(list, p => p.Name[0] == 'T');

            Console.WriteLine($"Sum = {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            #endregion
        }
    }
}
