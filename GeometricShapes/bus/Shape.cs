using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes.bus
{
    public abstract class Shape
    {
        private int idNumber;
        private string color;
        private EnumShapeType type;       

        public int IdNumber { get => idNumber; set => idNumber = value; }
        public string Color { get => color; set => color = value; }
        public EnumShapeType Type { get => type; set => type = value; }

       
        public Shape()
        {
            this.idNumber = 0;
            this.color = "undefined";
            this.type = EnumShapeType.Undefined;      
        }
        public Shape(int id, string color)
        {
            this.idNumber = id;
            this.color = color;
            this.type = EnumShapeType.Undefined;
        }
        public Shape(int id, string color, EnumShapeType type)
        {
            this.idNumber = id;
            this.color = color;
            this.type = type;            
        }
        public virtual double CalculateArea()
        {
            return 0.00;
        }
        public override string ToString() => this.idNumber + ", " + this.color + ", " + this.type ;
    }
}
