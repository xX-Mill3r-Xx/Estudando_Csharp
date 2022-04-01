using System;
using System.Globalization;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             DateTime
                • Representa um INSTANTE
                • É um tipo valor (struct)
                https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx
                • Agenda:
                • Representação interna
                • Instanciação: construtores, builders / conversão String -> DateTime
                • Formatação: DateTime -> String

                  obs.: using System;
             */

            /*Representação interna
                • Um objeto DateTime internamente armazena:
                • O número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de 
                janeiro do ano 1 da era comum
                DateTime d1 = DateTime.Now;
                Console.WriteLine(d1);
                Console.WriteLine(d1.Ticks);
            */

            DateTime date = DateTime.Now; //devolve o instante atual do sistema;
            Console.WriteLine(date);
            Console.WriteLine(date.Ticks); //imprime os tikcs até a data atual;

            /*Instanciação
                • Construtores
                • DateTime(ano, mes, dia)
                • DateTime(ano, mes, dia, hora, minuto, segundo) [opcional: kind]
                • DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo) [opcional: kind]
                • Builders
                • DateTime.Now
                • DateTime.UtcNow
                • DateTime.Today [time: 00:00:00]
                • DateTime.Parse(string)
                • DateTime.ParseExact(string, string)
            */

            //Demo - construtores
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            //Demo - Now, UtcNow, Today
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Today;
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            //Demo - Parse
            d1 = DateTime.Parse("2000-08-15");
            d2 = DateTime.Parse("2000-08-15 13:05:58");
            d3 = DateTime.Parse("15/08/2000");
            d4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            //Demo - ParseExact
            d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
            CultureInfo.InvariantCulture);
            d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.ReadLine();
        }
    }
}
