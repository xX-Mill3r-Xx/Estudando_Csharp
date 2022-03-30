using System;
using System.Globalization;

namespace Vetores_POO02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercicio 2 de vetores;
             * 
             Fazer um programa para ler um número inteiro N e os dados (nome e
                preço) de N Produtos. Armazene os N produtos em um vetor. Em
                seguida, mostrar o preço médio dos produtos.
             */

            Produto p = new Produto();

            Console.Write("Entre com a quantidade de produtos: ");
            int productsNames = int.Parse(Console.ReadLine());
            string[] nameProduct = new string[productsNames];
            double[] priceProduct = new double[productsNames];

            for(int i = 0; i < productsNames; i++)
            {
                Console.Write("Entre com o nome do Produto a ser Add: ");
                p.ProductName = Console.ReadLine();
                nameProduct[i] = p.ProductName;
                Console.Write("Entre com o preço do Produto a ser Add: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                priceProduct[i] = p.AddPrice(value);
            }
            double sum = 0.0;
            for(int i = 0; i< productsNames; i++)
            {
                Console.WriteLine($"Nome do produto: {nameProduct[i]}, Valor R${priceProduct[i].ToString("F2", CultureInfo.InvariantCulture)}");
                sum += priceProduct[i];
            }
            Console.WriteLine();
            double media = sum / productsNames;

            Console.WriteLine($"O preço medio dos produtos é R${media.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }
}
