using System;
using System.Globalization;

namespace Exercicio_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Em um banco, para se cadastrar uma conta bancaria, é nescessario informar o numero da conta, o nome do titular
            da conta e o valor de deposito inicial que o titular depositou ao abrir a conta. Este valor de deposito
            inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir
            sua conta, o deposito inicial não sera feito e o saldo inicial da conta sera, naturalmente zero;

            Importante.: uma vez que a conta bancaria foi aberta, o numero da conta nunca poderá ser alterado. ja o nome
            do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasioes de casamento por exemplo.)

            Por fim, o saldo da conta não podera ser alterado livrimente. É preciso implementar um mecanismo para proteger isso. O saldo só aumenta por meio de depositos, e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa de $5.00;
            Nota.: A conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa;

            Voce deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de deposito inicial. Em seguida, realizar um deposito e depois um saque, sempre mostrando os dados da conta apóes cada operação;

             */

            Conta c = new Conta();

            Console.Write("Entre com o numero da conta: ");
            c.AcontNumber = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            c.Name = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (s/n) ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                double DepositValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Deposit(DepositValue);
                Console.WriteLine($"Dados da conta: Conta {c.AcontNumber}, Titular: {c.Name}, Saldo: ${c.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"Dados da conta: Conta {c.AcontNumber}, Titular: {c.Name}, Saldo: ${c.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
                //mostra os dados da conta;
            }

            Console.Write("Entre com um valor para deposito: ");
            // deposito;
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposit(deposit);
            //mostra os dados da conta;
            Console.WriteLine(c);

            Console.Write("Entre com um valor para saque: ");
            // saque;
            double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.WithDraw(withDraw);
            //mostra os dados da conta;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
