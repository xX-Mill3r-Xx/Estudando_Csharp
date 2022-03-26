using System;
using System.Globalization;

namespace Exercicio_Classe01
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return $"Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Perimetro = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Diagonal = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
