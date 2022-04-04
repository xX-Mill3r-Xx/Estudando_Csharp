using System;
using System.Collections.Generic;
using MetodosAbstratos.Entities.Enuns;
using MetodosAbstratos.Entities;

namespace MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
