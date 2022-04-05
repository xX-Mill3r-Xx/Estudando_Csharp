using System;
using Exercicio_ExcecaoFixaxao.Entities;
using System.Globalization;

namespace Exercicio_ExcecaoFixaxao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Exercício de fixação
                Fazer um programa para ler os dados de uma conta bancária e depois realizar um 
                saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer 
                ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de 
                saque da conta. Implemente a conta bancária conforme projeto abaixo:*/
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int AccNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("WithDraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(AccNumber, holder, initialBalance, limit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.WithDraw(withDraw);
                Console.WriteLine($"New Balance: {acc}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error. Limite de saque não disponivel. {e.Message}");
            }
            Console.ReadLine();
        }
    }
}
