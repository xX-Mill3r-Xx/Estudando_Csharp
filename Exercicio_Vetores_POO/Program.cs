using System;

namespace Exercicio_Vetores_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             A dona de um pensionato possui dez quartos para alugar para estudantes,
            sendo esses quartos identificados pelos números 0 a 9.
            Quando um estudante deseja alugar um quarto, deve-se registrar o nome
            e email deste estudante.
            Fazer um programa que inicie com todos os dez quartos vazios, e depois
            leia uma quantidade N representando o número de estudantes que vão
            alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
            N estudantes. Para cada registro de aluguel, informar o nome e email do
            estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
            que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
            um relatório de todas ocupações do pensionato, por ordem de quarto,
            conforme exemplo.
             */

            Colleges c = new Colleges();

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            int[] quartos = new int[10];
            string[] study = new string[n];
            string[] mail = new string[n];
            Console.WriteLine();
            for(int i = 0 + 1; i < n; i++)
            {
                Console.WriteLine($"Rent# {i}");
                Console.Write("Name: ");
                c.Name = Console.ReadLine();
                study[i] = c.Name;
                Console.Write("Email: ");
                c.Email = Console.ReadLine();
                mail[i] = c.Email;
                Console.Write("Room: ");
                int RoomNumber = int.Parse(Console.ReadLine());
                quartos[i] = RoomNumber;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Rooms:");
            for(int i = 0 + 1; i < n; i++)
            {
                Console.WriteLine($"{quartos[i]}: {study[i]}, {mail[i]}");
            }
            Console.ReadLine();
        }
    }
}
