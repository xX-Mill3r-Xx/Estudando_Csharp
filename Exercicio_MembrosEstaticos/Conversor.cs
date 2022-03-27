using System.Globalization;

namespace Exercicio_MembrosEstaticos
{
    static class Conversor
    {
        public static double IOF = 6.0;
        public static double Dolar;
        public static double Reais;

        public static double valorDolar()
        {
            double total = (Dolar * Reais);
            return total + (total * IOF / 100.0);
        }
    }
}
