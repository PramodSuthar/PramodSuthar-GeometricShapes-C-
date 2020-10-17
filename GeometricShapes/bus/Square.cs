using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes.bus
{
    public class Square : Shape
    {
        private int side;

        public int Side { get => side; set => side = value; }

        public Square(): base()
        {
            this.side = 1;
        }

        public Square(int id, string color, EnumShapeType type, int side) : base(id, color, type)
        {
            this.side = side;
        }

        public override double CalculateArea() => side * side;

        public override string ToString() => base.ToString() + " the area is : " + CalculateArea();
    }
}

