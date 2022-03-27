using System;
using System.Globalization;

namespace Exercicio_MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler a cotação do dolar, e depois um valor em dolar a ser comprado por uma 
            pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dolares, considerando ainda que 
            a pessoa vat pagar 6% de IOF sobre o valor do dolar. Cria uma classe Conversor de Moedas para ser 
            responsavel pelos calculos.
             */

            Console.Write("Qual a cotação do dolar? ");
            Conversor.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce vai comprar? ");
            Conversor.Reais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = double.Parse(Conversor.valorDolar().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
