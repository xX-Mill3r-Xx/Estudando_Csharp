using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Encapsulamento é o principio que consiste em esconder detalhes de implementação de um componente,
            expondo apenas operações seguras e que o mantenham em um estado consistente.

            Dica: O Objeto deve sempre estar em um estado consistente e a propia classe deve garantir isso;
             */

            /*
             Opcão de implementação manual.

              - Todo atributo é definido como private;
              - Implementa-se métodos Get e Set para cada atributo, conforme regras de negocio;

            Nota.: não é usual na linguagem C#;
             */

            /*Vamos a um exemplo de emcapsulamento na pratica;*/

            Produto p = new Produto("TV", 500.00,10);

            p.SetName("Tv4K"); // para mudar o atributo nome usando o Set que acabamos de criar na classe produto;

            Console.WriteLine(p.GetName()); // para exibir o nome do produto usando o acessador que criamos na classe produto;
            Console.WriteLine(p.GetPrice()); // imprime o preço do produto;
            Console.WriteLine(p.GetQuantity()); // imprime a quantidade do produto;
            Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}
