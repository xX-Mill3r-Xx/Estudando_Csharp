using System;
using System.Collections.Generic;
using System.Globalization;
using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enuns;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Métodos abstratos
                • São métodos que não possuem implementação.
                • Métodos precisam ser abstratos quando a classe 
                é genérica demais para conter sua 
                implementação.
                • Se uma classe possuir pelo menos um método 
                abstrato, então esta classe também é abstrata.
                • Notação UML: itálico

                • Exercício resolvido

            Fazer um programa para ler os dados de N figuras (N fornecido
                pelo usuário), e depois mostrar as áreas destas figuras na
                mesma ordem em que foram digitadas.
             */

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char rc = char.Parse(Console.ReadLine());
                if(rc == 'r')
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color, radius));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("SHAPE AREAS:");

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
