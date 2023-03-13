using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    public class Circle : Figure //клас круга
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }

        public Circle(double x, double y, double radius)//конструктор для створення круга
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public double getx()// гетери
        {
            return X;
        }
        public double gety()
        {
            return Y;
        }
        public double getr()
        {
            return Radius;
        }
        public override double Area()//метод для знаходження площі круга
        {
            return Math.PI * Radius * Radius;
        }
      
        public override void Move(double dx, double dy)// метод для переміщення круга за координатами
        {
            X += dx;
            Y += dy;
        }

        public override void Scale(double factor)// метод для зміни розмірів круга
        {
            Radius *= factor;
        }
        public override void Rotate(double angle)
        {
            // Круги не змінюються при повороті
        }
    }
}
