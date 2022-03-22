using System;
using System.Globalization; // importei a blibioteca System.Globalization

namespace Exercicio_EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercicio 01;
             * Enunciado:
             * 
             Fazer um programa para ler as medidas da largura e comprimento de um terreno
            retangular com uma casa decimal, bem como o valor do metro quadrado do terreno
            com duas casas decimais. Em seguida, o programa deve mostrar o valor da area do
            terreno, bem como o valor do preço do terreno, ambos com duas casas decimais,
             */

            Console.Write("Entre com as medidas da largura do terreno: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com a medida do comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor do metro quadrado do terreno com duas casas decimais: ");
            double valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double preco = area * valorMetro;

            Console.WriteLine($"Area = {area.ToString("F2", CultureInfo.InvariantCulture)}M²");
            Console.WriteLine($"Preço = R${preco.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
