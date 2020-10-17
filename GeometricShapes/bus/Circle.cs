using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes.bus
{
    public class Circle : Shape
    {
        private int radius;

        public int Radiuse { get => radius; set => radius = value; }

        public Circle() : base()
        {
            this.radius = 1;
        }

        public Circle(int id, string color, EnumShapeType type, int radius) : base(id, color, type)
        {
            this.radius = radius;
        }

        public override double CalculateArea() => radius * radius * Math.Round(Math.PI, 2);

        public override string ToString() => base.ToString() + " the area is : " + CalculateArea();
    }
}
