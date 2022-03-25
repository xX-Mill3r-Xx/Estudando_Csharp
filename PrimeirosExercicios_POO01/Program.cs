using System;

namespace PrimeirosExercicios_POO01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             EXERCÍCIO 01:
                Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais 
                velha.
             */

            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if(p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha é: {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha é: {p2.Nome}");
            }
            Console.ReadLine();
        }
    }
}
