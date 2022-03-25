using System;
using System.Globalization;

namespace PrimeirosExercicios_POO02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             EXERCÍCIO 02:
                Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário 
                médio dos funcionários.
             */

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine();
            Console.WriteLine($"Salario medio = ${media.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }
}
