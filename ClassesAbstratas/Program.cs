using System;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Classes abstratas
                • São classes que não podem ser instanciadas
                • É uma forma de garantir herança total: somente subclasses não 
                abstratas podem ser instanciadas, mas nunca a superclasse abstrata

            Suponha que em um negócio relacionado a banco, apenas
                contas poupança e contas para empresas são permitidas.
                Não existe conta comum.
                Para garantir que contas comuns não possam ser
                instanciadas, basta acrescentarmos a palavra "abstract" na
                declaração da classe.
                        namespace Course {
                                abstract class Account {
                                (...)
                Notação UML: itálico

            Questionamento
                • Se a classe Account não pode ser instanciada, por que simplesmente não criar somente SavingsAccount e
                BusinessAccount?
                • Resposta: • Reuso
                • Polimorfismo: a superclasse classe genérica nos permite
                tratar de forma fácil e uniforme todos os tipos de conta,
                inclusive com polimorfismo se for o caso (como fizemos nos
                últimos exercícios). Por exemplo, você pode colocar todos
                tipos de contas em uma mesma coleção.
                • Demo: suponha que você queira: • Totalizar o saldo de todas as contas.
                • Sacar 10.00 de todas as contas.
             */


        }
    }
}
