using System;
using System.Collections.Generic;
using Entities;
using Services;
using System.Globalization;

namespace RestricoesGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uma empresa de consultoria deseja avaliar a performance de produtos, funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar o maior dentre um conjunto de elementos. Fazer um programa que leia um conjunto de N produtos, conforme exemplo, e depois mostre o mais caro deles.*/

            #region Versão light
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter value: ");
                string[] vet = Console.ReadLine().Split(',');
                string name = vet[0];
                double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(list);
            Console.Write("Max Value is: ");
            Console.WriteLine(max);
            #endregion

            /*Restrições possíveis
                • https://docs.microsoft.com/en-us/dotnet/csharp/programmingguide/generics/constraints-on-type-parameters
                • where T: struct • where T : class
                • where T : unmanaged
                • where T : new() • where T : <base type name>
                • where T : U*/
        }
    }
}
