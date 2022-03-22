using System;

namespace Estrutura_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Estrutura Switch Case.

            Quando se tem tres ou mais opçoes de fluxo a serem tratadas com
            base no valor de uma variavel, ao invez de varias estruturas if-else encadeadas,
            podemos usar a estrutura switch-case;
             */

            /*
             Um exemplo com um exercicio:
            Fazer um programa para ler um valor inteiro de 1 a 7 representando um dia da semana,
            sendo 1 = dominfo, 2 = segunda, e assim por diante.
            Escrever na tela o dia da semana correspondente;
             */

            Console.Write("Entre com o dia da semana: ");
            int diaSemana = int.Parse(Console.ReadLine());
            switch (diaSemana)
            {
                default:
                    Console.WriteLine("Entre com um dia valido!");
                    break;

                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Segunda");
                    break;

                case 3:
                    Console.WriteLine("Terça");
                    break;

                case 4:
                    Console.WriteLine("Quarta");
                    break;

                case 5:
                    Console.WriteLine("Quinta");
                    break;

                case 6:
                    Console.WriteLine("Sexta");
                    break;

                case 7:
                    Console.WriteLine("Sabado");
                    break;
            }
            Console.ReadLine();
        }
    }
}
