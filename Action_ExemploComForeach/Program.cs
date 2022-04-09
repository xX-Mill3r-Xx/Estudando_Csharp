using System;
using System.Collections.Generic;
using Entities;

namespace Action_ExemploComForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Action (System)
                • Representa um método void que recebe zero ou mais argumentos
                • https://msdn.microsoft.com/en-us/library/system.action%28v=vs.110%29.aspx

                public delegate void Action();
                public delegate void Action<in T>(T obj);
                public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
                public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);

            Problema exemplo
                Fazer um programa que, a partir de uma lista de produtos, aumente o preço dos produtos em 10%.
             */

            #region Exemplo
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            #endregion
        }
    }
}
