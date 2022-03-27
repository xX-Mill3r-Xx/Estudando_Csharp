using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Construtor é uma operação especial da classe, que executa no momento da instanciação do objeto;
            
            Usos Comuns:
             - Iniciar valores dos atributos
             - Permitir ou obrigar que o objeto receba dados/dependencias no momento de sua instanciação (injeção de dependencia)

            Se um construtor customizado não for especificado, a classe disponibiliza o construtor padrao;
             - Produto p = new Produto();

            É possivel especificar mais de um construtor na mesma classe (Sobrecarga);
             */

            /*
             Veja um exemplo na pratica;
             */

            Produto p = new Produto("TV",900.00,10);
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

            /*
             Proposta de melhoria.
              Quando executamos o comando "p = new Produto", instanciamos um produto p com seus atributos vazios;

              Entretanto, faz sentido um produto que não tem nome? Faz sentido um produto que não tem preço?

              Com o intuito de evitar a existencia de produtos sem nome e sem preço, é possivel fazer com que seja "Obrigatorio" a inicialização destes valores.
             */

        }
    }
}
