using System;

namespace IntroGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Generics;

            - Generics permitem que classes, interfaces e metodos possam ser parametrizados por tipo. Seus beneficios são:
              - Reuso;
              - Type safety
              - Performace

            - Uso comum: Coleçoes;
             */

            /*
             * Problema Exemplo (Reuso) 
                Deeseja-se fazer um programa que leia um conjunto de N números inteiros (N de 1 a 10), e depois imprima esses números de forma organizada conforme exemplo. Em seguida, informar qual foi o primeiro valor informado.
             */

            // usando a classe em int
            #region Modelo da primeira aula - versão Int
            //PrintService printService = new PrintService();
            //Console.Write("How many values? ");
            //int values = int.Parse(Console.ReadLine());

            //for(int i = 0; i < values; i++)
            //{
            //    Console.Write($"Entre com o valor: ");
            //    int x = int.Parse(Console.ReadLine());
            //    printService.AddValue(x);
            //}

            //printService.Print();
            //Console.WriteLine($"First: {printService.First()}");
            #endregion

            //usando a classe em string
            #region Modelo da segunda aula - versão string
            //PrintServiceString printServiceString = new PrintServiceString();
            //Console.Write("How many values? ");
            //int values = int.Parse(Console.ReadLine());

            //for (int i = 0; i < values; i++)
            //{
            //    Console.Write($"Entre com o nome: ");
            //    string x = Console.ReadLine();
            //    printServiceString.AddValue(x);
            //}

            //printServiceString.Print();
            //Console.WriteLine($"First: {printServiceString.First()}");
            #endregion

            //usando a classe em object
            #region Modelo da segunda aula - versão object
            /*Esta solução não tem Type Safety*/

            //PrintServiceObject printServiceObject = new PrintServiceObject();
            //Console.Write("How many values? ");
            //int values = int.Parse(Console.ReadLine());

            //for (int i = 0; i < values; i++)
            //{
            //    Console.Write($"Entre com o valor: ");
            //    string x = Console.ReadLine();
            //    printServiceObject.AddValue(x);
            //}

            ///**/
            ///*Devemos evitar o uso do object, pois o object pode ser qualquer objeto e não tera o suporte do Type Safety*/
            //int a = (int)printServiceObject.First();
            //int b = a;
            //Console.WriteLine(b);
            ///**/

            //printServiceObject.Print();
            //Console.WriteLine($"First: {printServiceObject.First()}");
            #endregion

            // usando a classe parametrizada
            #region Modelo Parametrizado<T> - versão Generic string
            PrintServiceParametrizado<string> printServiceParametrizadostring = new PrintServiceParametrizado<string>();
            Console.Write("How many values? ");
            int valuesString = int.Parse(Console.ReadLine());

            for (int i = 0; i < valuesString; i++)
            {
                Console.Write($"Entre com o nome: ");
                string x = Console.ReadLine();
                printServiceParametrizadostring.AddValue(x);
            }

            printServiceParametrizadostring.Print();
            Console.WriteLine($"First: {printServiceParametrizadostring.First()}");
            Console.WriteLine();
            #endregion

            #region Modelo Parametrizado<T> - versão Generic int
            PrintServiceParametrizado<int> printServiceParametrizadoInt = new PrintServiceParametrizado<int>();
            Console.Write("How many values? ");
            int valuesInt = int.Parse(Console.ReadLine());

            for (int i = 0; i < valuesInt; i++)
            {
                Console.Write($"Entre com o valor: ");
                int x = int.Parse(Console.ReadLine());
                printServiceParametrizadoInt.AddValue(x);
            }

            printServiceParametrizadoInt.Print();
            Console.WriteLine($"First: {printServiceParametrizadoInt.First()}");
            #endregion
        }
    }
}
