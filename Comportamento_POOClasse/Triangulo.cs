using System;

namespace Comportamento_POOClasse
{
    class Triangulo
    {
        //Declarando os atributos do triangulo;
        public double A;
        public double B;
        public double C;

        // adcionando um metodo para ser responsavel pelo calculo da area;
        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p*(p - A)*(p - B)*(p - C));
            return area;
        }
    }
}
