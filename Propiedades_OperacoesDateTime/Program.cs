using System;

namespace Propiedades_OperacoesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Propriedades
                • Date (DateTime)
                • Day (int)
                • DayOfWeek (DayOfWeek)
                • DayOfYear (int)
                • Hour (int)
                • Kind (DateTimeKind)
                • Millisecond (int)
                • Minute (int)
                • Month (int)
                • Second (int)
                • Ticks (long)
                • TimeOfDay (TimeSpan)
                • Year (int)
            */

            //Demo
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            //Formatação (DateTime -> string)
            d = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            //Operações com Datetime
            //DateTime x = ...;
            //DateTime y = x.Add(timeSpan);
            //y = x.AddDays(double);
            //y = x.AddHours(double);
            //y = x.AddMilliseconds(double);
            //y = x.AddMinutes(double);
            //y = x.AddMonths(int);
            //y = x.AddSeconds(double);
            //y = x.AddTicks(long);
            //y = x.AddYears(int);
            //y = x.Subtract(timeSpan);
            //TimeSpan t = x.Subtract(dateTime);
        }
    }
}
