using System;
using System.Globalization;

namespace Comportamento_POOClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Criando uma classe para representar melhor o nosso triangulo;

            Discussão: Triangulo é uma entidade com tres atributos: A,B,C.
            Estamos usando tres variaveis distintas para representar cada triangulo:
            double XA,XB,XC e YA,YB,YC

            para melhorar isso, vamos usar uma classe para representar um triangulo;
             */

            #region Explicacao sobre Classes
            /*
             Classe:
            É um tipo estruturado que pode conter membros:
             - Atributos (dados/campos);
             - Metodos (Funçoes/operaçoes);

            A classe tambem pode prover muitos outros recursos, tais como:
             - Construtores,
             - Sobrecarga,
             - Encapsulamento,
             - Herança,
             - Polimorfismo;

            Exemplos:
             - Entidades: Produto, Cliente, Triangulo;
             - Serviços: ProductServices, ClientServices, EmailServices, StorageServices;
             - Utilitarios: Calculadora, Compactador;
             */
            #endregion

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            #region Triangulo X
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            #region Codigo Obsoleto
            //Console.Write("Lado A: ");
            //double XA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Lado B: ");
            //double XB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Lado C: ");
            //double XC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            #endregion

            #endregion

            Console.WriteLine();
            
            #region Triangulo Y
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            #region Codigo Obsoleto
            //Console.Write("Lado A: ");
            //double YA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Lado B: ");
            //double YB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Lado C: ");
            //double YC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            #endregion

            #endregion

            #region Calculos das areas dos triangulos X e Y

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A)*(p - x.B)*(p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            #region Codigo Obsoleto
            //double pX = (XA + XB + XC) / 2.0;
            //double areaX = Math.Sqrt(pX * (pX - XA) * (pX - XB) * (pX - XC));
            //double pY = (YA + YB + YC) / 2.0;
            //double areaY = Math.Sqrt(pY * (pY - YA) * (pY - YB) * (pY - YC));
            #endregion

            #endregion

            Console.WriteLine();

            Console.WriteLine($"Area de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            Console.WriteLine();

            if (areaX < areaY)
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
