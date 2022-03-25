using System;
using System.Globalization;

namespace Exercicio_POOAplicado01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque).
            Em seguida, Mostrar os dados do produto (nome, preço e quantidade. Valor total no estoque)
             - Realizar uma entrada no estoque e mostrar novamente os dados do produto.
             - Realizar uma saida no estoque e mostrar novamente os dados do produto.

            Para resolver este problema voce deve criar uma classe Produto;
             */

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p.Name}, ${p.Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{p.Quantity} Unidades, Total: ${p.TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite o numero de produtos a serem add no estoque: ");
            int add = int.Parse(Console.ReadLine());
            p.AddProduct(add);
            Console.WriteLine($"Dados atualizados: {p.Name}, ${p.Price.ToString("F2", CultureInfo.InvariantCulture)}," +
                $"{p.Quantity} Unidades, Total: ${p.TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite o numero de produtos a serem removidos no estoque: ");
            int remove = int.Parse(Console.ReadLine());
            p.RemoveProduct(remove);
            Console.WriteLine($"Dados atualizados: {p.Name}, ${p.Price.ToString("F2", CultureInfo.InvariantCulture)}," +
                $"{p.Quantity} Unidades, Total: ${p.TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
