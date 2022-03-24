using System;
using System.Globalization;

namespace Comportamento_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Vamos aqui, resolver um problema exemplo, porem sem o uso da programação orientada a objetos em C#

            Fazer um programa para ler as medidas dos lados de dois triangulos X e Y (Suponha medidas validas).
            Em seguida, mostrar o valor das areas dos dois triangulos e dizer qual dos dois triangulos possui a 
            maior area;

            A formula para calcular a area de um triangulo a partir das medidas de seus lados a, b, c é 
            formula de Heron: area = raiz² p(p-a)(p-b)(p-c) onde p = a + b + c / 2.0;
             */
            #region Triangulo X
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            Console.Write("Lado A: ");
            double XA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            double XB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            double XC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            #endregion

            Console.WriteLine();

            #region Triangulo Y
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            Console.Write("Lado A: ");
            double YA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            double YB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            double YC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            #endregion

            #region Calculos das areas dos triangulos X e Y
            double pX = (XA + XB + XC) / 2.0;
            double areaX = Math.Sqrt(pX * (pX - XA) * (pX - XB) * (pX - XC));
            double pY = (YA + YB + YC) / 2.0;
            double areaY = Math.Sqrt(pY * (pY - YA) * (pY - YB) * (pY - YC));
            #endregion

            Console.WriteLine();

            Console.WriteLine($"Area de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            Console.WriteLine();

            if(areaX < areaY)
            {
                Console.WriteLine("Maior area = Y");
            }
            else
            {
                Console.WriteLine("Maior area = X");
            }

            Console.ReadLine();
        }
    }
}
