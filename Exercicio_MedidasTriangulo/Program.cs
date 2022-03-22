using System;
using System.Globalization;

namespace Exercicio_MedidasRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercicio Medidas de um retangulo;
            Enunciado:

            Fazer um programa para ler as medidas da base e altura de um retangulo. Em seguida
            mostrar o valor da area, perimetro e diagonal dete retangulo, com quatro casas decimais.
             */

            Console.Write("Entre com a medida da base: ");
            double RetBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com a medida da altura: ");
            double RetAltura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = RetBase * RetAltura;
            double perimetro = 2 * (RetBase + RetAltura);
            double diagonal = Math.Sqrt(Math.Pow(RetBase, 2) + Math.Pow(RetAltura, 2));

            Console.WriteLine($"Area = {area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perimetro = {perimetro.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {diagonal.ToString("F4", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
