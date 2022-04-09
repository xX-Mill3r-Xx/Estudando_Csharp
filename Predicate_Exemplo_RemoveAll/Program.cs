using System;
using System.Collections.Generic;
using Entities;

namespace Predicate_Exemplo_RemoveAll
{
    #region Delegate
    public delegate bool Predicate<in T>(T obj);
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            /*
             Predicate (System)
                • Representa um método que recebe um objeto do tipo T e retorna um valor booleano
                • https://msdn.microsoft.com/en-us/library/bfcke1bz%28v=vs.110%29.aspx
             */

            /*
             Problema exemplo
                Fazer um programa que, a partir de uma lista de produtos, remova da lista somente aqueles cujo preço mínimo seja 100.
             */

            #region Exemplo
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(p => p.Price >= 100.0);
            foreach (Product p in list)
            {
                Console.WriteLine(p);

            }
            #endregion
        }
    }
}
