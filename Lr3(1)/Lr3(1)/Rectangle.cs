using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3_1_
{
    public class Rectangle : Figure //клас прямокутника
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double wight, double heidht)// конструктор
        {
            Width = wight;
            Height = heidht;

        }

        public override double GetArea() // метод для обчислення площі прямокутника
        {
            return Width * Height;
        }

        public override double GetPerimeter() // метод для обчислення периметру
        {
            return 2 * (Width + Height);
        }
    }
}
