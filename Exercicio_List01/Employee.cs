using System.Globalization;

namespace Exercicio_List01
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee()
        {
        }

        public Employee(int iD, string name, double salary)
        {
            ID = iD;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percent)
        {
            Salary += Salary * percent / 100.0;
        }

        public override string ToString()
        {
            return $"{ID}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
