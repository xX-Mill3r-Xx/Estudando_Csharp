using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Encapsulamento
{
    class Conta
    {
        private double Taxes = 5.0;
        private int _acountNumber;

        public string Name { get; set; }
        public double Balance { get; private set; }

        public int AcontNumber
        {
            get { return _acountNumber; }
            set { _acountNumber = value; }
        }

        public Conta()
        {
        }

        public Conta(int acountNumber, string name, double balance)
        {
            _acountNumber = acountNumber;
            Name = name;
            Balance = balance;
        }

        public double Deposit(double value)
        {
            return Balance += value;
        }

        public double WithDraw(double value)
        {
            return Balance -= (value + Taxes);
        }

        public override string ToString()
        {
            return $"Dados da conta Atualizados: Conta {_acountNumber}, Titular: {Name}, Saldo: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
