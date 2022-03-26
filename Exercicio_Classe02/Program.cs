using System;
using System.Globalization;

namespace Exercicio_Classe02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler os dados de um funcionario (nome, salario bruto e imposto).
            Em seguida, mostrar na tela os dados do funcionario (nome e salario liquido). 
            Em seguida, aumentar o salario do funcionario com base em uma porcentagem dada (somente o salario bruto
            é afetado pela porcentagem) e mostrar novamente os dados do funcionario. Use a classe Funcionario;
             */

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Name = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Taxes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionario: {f.Name}, ${f.NetSalary().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double add = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AddSalary(add);

            Console.WriteLine();
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
