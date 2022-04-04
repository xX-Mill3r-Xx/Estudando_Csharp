using System;
using System.Collections.Generic;
using MetodosAbstratos.Entities.Enuns;

namespace MetodosAbstratos.Entities
{
    class Rectangle : Shape
    {
        public double Widht { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(Color color, double widht, double height) : base(color)
        {
            Widht = widht;
            Height = height;
        }

        public override double Area()
        {
            return Widht * Height;
        }
    }
}
