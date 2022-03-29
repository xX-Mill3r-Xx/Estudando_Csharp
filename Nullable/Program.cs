﻿using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Nullable
                • É um recurso de C# para que dados de tipo valor (structs) possam 
                receber o valor null
                • Uso comum:
                • Campos de banco de dados que podem valer nulo (data de nascimento, 
                algum valor numérico, etc.).
                • Dados e parâmetros opcionais.

            Demo
                double x = null; // erro
                Nullable<double> x = null;
                double? x = null;
                • Métodos:
                • GetValueOrDefault
                • HasValue
                • Value (lança uma exceção se não houver valor)
                • Um nullable não pode ser atribuído para um struct comum
                • Valor default para tipos:
            https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/default-value-expression
             */

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            /*
             Operador de coalescência nula
                • https://docs.microsoft.com/en-us/dotnet/csharp/languagereference/operators/null-conditional-operator
                • Demo:
                double? x = null;
                double y = x ?? 0.0;
             */

            double? z = null;
            double? w = 10;

            double a = z ?? 5;
            double b = w ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
