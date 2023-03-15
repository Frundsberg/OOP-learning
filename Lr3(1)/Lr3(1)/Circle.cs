using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3_1_
{
    class Circle : Figure //клас для кола, методи для площі і периметру
    {
        public double Radius { get; set; }
        public Circle(double radius)// конструктор
        {
            Radius = radius;
        }

        public override double GetArea() //методи
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
