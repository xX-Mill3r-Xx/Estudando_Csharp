using System;
using System.Globalization;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Sobrecarga é um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porem com diferentes
            listas de parametros;
             */

            /*
             Proposta de melhoria.
              - Vamos criar um construtor opcional, o qual recebe apenas nome e preço do produto. A quantidade em estoque deste novo
            produto, por padrão, deverá então ser iniciada com o valor de zero;

              - Nota.: é possivel tambem incluir um construtor padrão (sem parametros)
            
            Exercicio como exemplo;
             */

            Produto p = new Produto("TV", 900.00, 10);
            Console.WriteLine($"Dados: {p.Name}, ${p.Price}, {p.Quantity} unidades");

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p.Name}, ${p.Price.ToString("F2", CultureInfo.InvariantCulture)}, {p.Quantity} unidades. Total: ${p.TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite a quantidade que deseja add ao estoque: ");
            int add = int.Parse(Console.ReadLine());
            p.AddProduct(add);

            Console.WriteLine(p);

            Console.Write("Digite a quantidade que deseja remover do estoque: ");
            int remove = int.Parse(Console.ReadLine());
            p.RemoveProduct(remove);

            Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}
