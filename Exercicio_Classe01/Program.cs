using System;
using System.Globalization;

namespace Exercicio_Classe01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler os valores da largura e altura de um retangulo.
            Em seguida, mostrar na tela o valor de sua area, perimetro e diagonal. Usar uma classe para
            representar o retangulo;
             */

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura ro retangulo");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            r.Area();
            r.Perimetro();
            r.Diagonal();

            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
