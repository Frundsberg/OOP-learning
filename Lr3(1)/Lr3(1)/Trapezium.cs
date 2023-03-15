using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3_1_
{
    class Trapezium : Figure // клас трапеції
    {
        public double Base1 { get; set; } // змінні для основи трапеції, висоти і сторін
        public double Base2 { get; set; }
        public double Height { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public Trapezium(double base1, double base2, double height, double side1, double side2)// конструктор
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
            Side1 = side1;
            Side2 = side2;

        }

        public override double GetArea()// методи для обчислення площі і периметру
        {
            return (Base1 + Base2) * Height / 2;
        }

        public override double GetPerimeter()
        {
            return Base1 + Base2 + Side1 + Side2;
        }
    }
}
