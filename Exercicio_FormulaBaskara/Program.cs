using System;
using System.Globalization;

namespace Exercicio_FormulaBaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercicio Formula de Baskara - Uri1036

            Leia tres valores de ponto flutuante e efetue o calculo das raizes da equação de Baskara. Se não for possivel
            calcular as raizes, mostre a mesnagem correspondente "Impossivel calcular" caso haja uma divisão por 0 ou
            raiz de numero negativo
             */

            double A, B, C;

            Console.Write("Entre com os tres valores para calcular. Obs.: na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(B, 2.0) - 4 * A * C;

            if(delta <= 0.0 || A == 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double R1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                double R2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine($"R1 = {R1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {R2.ToString("F5", CultureInfo.InvariantCulture)}");
            }

            Console.ReadLine();
        }
    }
}
