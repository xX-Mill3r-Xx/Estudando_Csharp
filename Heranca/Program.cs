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

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.0);

            
        }
    }
}
