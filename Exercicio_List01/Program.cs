using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_List01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
                N funcionários. Não deve haver repetição de id.
                Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
                Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
                mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
                conforme exemplos.
                Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
                ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
                aumento por porcentagem dada.*/

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> funcionarios = new List<Employee>();

            for(int i = 0 + 1; i < n + 1; i++)
            {
                Console.WriteLine($"Employer #{i}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.Add(new Employee(id, name, value));
                Console.WriteLine();
            }

            Inicio:
            Console.Write("Enter the employee id that will have salary increase: ");
            int increase = int.Parse(Console.ReadLine());

            Employee e = funcionarios.Find(x => x.ID == increase);
            if (e != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("Enter one valid Employee ID!");
                goto Inicio;
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in funcionarios)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
