using System;
using System.Collections.Generic;
using Entities;

namespace ComoHashTestam_Igualdade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Como as coleções Hash testam igualdade?

                • Se GetHashCode e Equals estiverem implementados: 
                   • Primeiro GetHashCode. Se der igual, usa Equals para confirmar. 

                • Se GetHashCode e Equals NÃO estiverem implementados: 
                   • Tipos referência: compara as referências dos objetos
                   • Tipos valor: comparar os valores dos atributos

            #####################################################################################################################

              Problema Exemplo;
             */

            #region Exercicio Exemplo
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));
            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));
            Point point = new Point(5, 10);
            Console.WriteLine(b.Contains(point));

            Console.ReadLine();
            #endregion

        }
    }
}
