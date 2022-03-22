using System;

namespace Exercicio_Uri1113
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y
            uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente;

            Entrada: A entrada deve conter varios casos de testes. Cada caso contem dois valores int X e Y.
            A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y;

            Saida: Para cada caso de teste, imprima "Crescente", caso os valores tenham sido digitados na ordem crescente.
            caso contrario, imprima a mensagem "Decrescente";
             */

            int X, Y;
            Console.Write("Entre com os valores para X e Y: ");
            string[] vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            while(X != Y)
            {
                if (X > Y)
                {
                    Console.WriteLine(vet[0], vet[1]);
                    Console.WriteLine("Decrescente");

                }
                else
                {
                    Console.WriteLine(vet[0], vet[1]);
                    Console.WriteLine("Crescente");
                }
                Console.Write("Entre com os valores para X e Y: ");
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }

            Console.ReadLine();
        }
    }
}
