using Composicao.Entities.Enums;
using System.Globalization;
using Composicao.Entities;
using System;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Composição
                • É um tipo de associação que permite que um objeto contenha outro
                • Relação "tem-um" ou "tem-vários"
                • Vantagens
                • Organização: divisão de responsabilidades
                • Coesão
                • Flexibilidade
                • Reuso
                • Nota: embora o símbolo UML para composição (todo-parte) seja o diamante preto, neste contexto estamos chamando de composição qualquer associação 
                tipo "tem-um" e "tem-muitos".
            */

            /*Exercicio Exemplo
             Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar 
             do usuário um mês e mostrar qual foi o salário do funcionário nesse mês.
             */

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(workerName, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration: ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"Income for {monthYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)} ");

            Console.ReadLine();
        }
    }
}
