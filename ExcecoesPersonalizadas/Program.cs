using System;
using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Entities.Exceptions;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data
                de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
                dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
                novamente a reserva com os dados atualizados. O programa não deve aceitar dados
                inválidos para a reserva, conforme as seguintes regras:
                - Alterações de reserva só podem ocorrer para datas futuras
                - A data de saída deve ser maior que a data de entrada
             */

            /*Obs.: • Solução 1 (muito ruim): lógica de validação no programa principal
                    • Lógica de validação não delegada à reserva*/

            #region Solução 1 - Ruim
            //Console.Write("Room number: ");
            //int roomNumber = int.Parse(Console.ReadLine());

            //Console.Write("Check-in date (dd/MM/yyyy): ");
            //DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //Console.Write("Check-out date (dd/MM/yyyy): ");
            //DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //if (checkOut <= checkIn)
            //{
            //    Console.WriteLine("Error in reservation!");
            //}
            //else
            //{
            //    Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
            //    Console.WriteLine($"Reservation: {reservation}");

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation: ");
            //    Console.Write("Check-in date (dd/MM/yyyy): ");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-out date (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    DateTime now = DateTime.Now;
            //    if(checkIn < now || checkOut < now)
            //    {
            //        Console.WriteLine("Error in reservation!");
            //    }
            //    else if(checkOut <= checkIn)
            //    {
            //        Console.WriteLine("Error in reservation!");
            //    }
            //    else
            //    {
            //        reservation.UpdateDate(checkIn,checkOut);
            //        Console.WriteLine($"Reservation: {reservation}");
            //    }
            //}
            #endregion

            /*obs.: • Solução 2 (ruim): método retornando string
                    • A semântica da operação é prejudicada
                    • Retornar string não tem nada a ver com atualização de reserva
                    • E se a operação tivesse que retornar um string?
                    • Ainda não é possível tratar exceções em construtores
                    • A lógica fica estruturada em condicionais aninhadas*/

            #region Solucao 2 - Ainda Ruim

            //Console.Write("Room number: ");
            //int roomNumber = int.Parse(Console.ReadLine());

            //Console.Write("Check-in date (dd/MM/yyyy): ");
            //DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //Console.Write("Check-out date (dd/MM/yyyy): ");
            //DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //if (checkOut <= checkIn)
            //{
            //    Console.WriteLine("Error in reservation!");
            //}
            //else
            //{
            //    Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
            //    Console.WriteLine($"Reservation: {reservation}");

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation: ");
            //    Console.Write("Check-in date (dd/MM/yyyy): ");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-out date (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    string error = reservation.UpdateDate(checkIn, checkOut);
            //    if (error != null)
            //    {
            //        Console.WriteLine($"Error in reservation {error}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Reservation: {reservation}");
            //    }
            //}

            #endregion

            /**/

            #region Modelo Correto

            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDate(checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch(DomainExceptions e)
            {
                Console.WriteLine($"Error in reservation {e.Message}");
            }

            #endregion

            /*Resumo da aula
                • Cláusula throw: lança a exceção / "corta" o método
                • O modelo de tratamento de exceções permite que erros sejam tratados de forma 
                consistente e flexível, usando boas práticas
                • Vantagens:
                • Lógica delegada
                • Construtores podem ter exceções
                • Código mais simples. Não há aninhamento de condicionais: a qualquer momento que uma 
                exceção for disparada, a execução é interrompida e cai no bloco catch correspondente.
                • É possível capturar inclusive outras exceções de sistema*/

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
