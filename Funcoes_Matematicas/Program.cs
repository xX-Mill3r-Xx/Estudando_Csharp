using System;

namespace Funcoes_Matematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //funçoes matematica em c#
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double a, b, c;

            a = Math.Sqrt(x);
            b = Math.Sqrt(y);
            c = Math.Sqrt(25.0);

            Console.WriteLine($"Raiz quadrade de {x} = {a}");
            Console.WriteLine($"Raiz quadrade de {y} = {b}");
            Console.WriteLine($"Raiz quadrade de 25 = {c}");

            a = Math.Pow(x, y);
            b = Math.Pow(x, 2.0);
            c = Math.Pow(5.0, 2.0);
            Console.WriteLine($"{x} elevado a {y} = {a}");
            Console.WriteLine($"{x} elevado ao quadrado = {b}");
            Console.WriteLine($"5 elevado ao quadrado = {c}");

            a = Math.Abs(y);
            b = Math.Abs(z);
            Console.WriteLine($"O valor absoluto de {y} é {a}");
            Console.WriteLine($"O valor absoluto de {z} é {b}");

            // é possivel incluir formulas mais complexas como por exemplo a formula de baskara;
            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.ReadLine();
        }
    }
}

