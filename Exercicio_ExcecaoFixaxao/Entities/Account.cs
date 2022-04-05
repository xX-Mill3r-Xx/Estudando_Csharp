using System;
using System.Globalization;

namespace Exercicio_ExcecaoFixaxao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(Balance >= WithDrawLimit)
            {
                Console.WriteLine("Withdraw error: The amount exceeds withdraw limit");
            }
            else
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"New balance: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
