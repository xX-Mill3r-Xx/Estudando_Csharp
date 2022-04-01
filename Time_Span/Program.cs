using System;

namespace Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TimeSpan
                • Representa uma DURAÇÃO
                • É um tipo valor (struct)
                https://msdn.microsoft.com/en-us/library/system.timespan(v=vs.110).aspx
                Agenda:
                • Representação interna
                • Instanciação: construtores, fields, métodos From, Parse

                  obs.: using System;
            */

            /*Representação interna
                • Um objeto TimeSpan internamente armazena uma duração na forma 
                de ticks (100 nanosegundos)
            */

            TimeSpan time1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(time1);
            Console.WriteLine(time1.Ticks);

            /*Construtores
                • TimeSpan()
                • TimeSpan(ticks)
                • TimeSpan(horas, minutos, segundos)
                • TimeSpan(dias, horas, minutos, segundos)
                • TimeSpan(dias, horas, minutos, segundos, milissegundos)
            */

            //Demo Construtores
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            //Demo - métodos From
            t1 = TimeSpan.FromDays(1.5);
            t2 = TimeSpan.FromHours(1.5);
            t3 = TimeSpan.FromMinutes(1.5);
            t4 = TimeSpan.FromSeconds(1.5);
            t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            Console.ReadLine();
        }
    }
}
