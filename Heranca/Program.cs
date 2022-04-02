using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Herança
                • É um tipo de associação que permite que uma classe herde dados e 
                comportamentos de outra
                • Definições importantes
                • Vantagens
                • Reuso
                • Polimorfismo
                • Sintaxe
                • : (estende)
                • base (referência para a superclasse)
            */

            /*Exemplo
                    Suponha um negócio de banco que possui uma conta comum e uma conta para 
                    empresas, sendo que a conta para empresa possui todos membros da conta 
                    comum, mais um limite de empréstimo e uma operação de realizar empréstimo.
            */

            /*Herança permite o reuso de atributos e 
              métodos (dados e comportamento)*/

            /*      • Relação "é-um"
                    • Generalização/especialização
                    • Superclasse (classe base) / subclasse (classe 
                    derivada)
                    • Herança / extensão
                    • Herança é uma associação entre classes (e não 
                    entre objetos)
            */

            /*Demo
                Vamos implementar as classes
                Account e BusinessAccount e fazer
                alguns testes.
            */

            /*Upcasting e downcasting
             * Checklist
                • Upcasting
                • Casting da subclasse para superclasse
                • Uso comum: polimorfismo
                • Downcasting
                • Casting da superclasse para subclasse
                • Palavra as
                • Palavra is
                • Uso comum: métodos que recebem parâmetros genéricos (ex: Equals)
            */

            Accont acc = new Accont(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UpCasting
            Accont acc1 = bacc;
            Accont acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Accont acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DownCasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //BusinessAccount acc5 = (BusinessAccount)acc3; //da erro;
            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // usando o as
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpDateBalance();
                Console.WriteLine("Update!");
            }

            Accont acCont = new Accont(1001, "Alex", 500.00);
            Accont acCont2 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            acCont.WithDraw(300.00);
            acCont2.WithDraw(300.00);

            Console.WriteLine(acCont.Balance);
            Console.WriteLine(acCont2.Balance);

            Console.ReadLine();
        }
    }
}
