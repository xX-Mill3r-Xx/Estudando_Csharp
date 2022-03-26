using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Classe02
{
    class Funcionario
    {
        public string Name;
        public double GrossSalary;
        public double Taxes;

        public double NetSalary()
        {
            return GrossSalary - Taxes;
        }

        public void AddSalary(double percent)
        {
            GrossSalary += (GrossSalary * percent / 100.0);
        }

        public override string ToString()
        {
            return $"Dados Atualizados: {Name}, ${NetSalary().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
