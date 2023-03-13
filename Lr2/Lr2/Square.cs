using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    class Square : Figure //клас квадрата
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }
        public Square(double x, double y, double size)
        {
            X = x;
            Y = y;
            Size = size;
        }
        public double getx()// гетери
        {
            return X;
        }
        public double gety()
        {
            return Y;
        }
        public double get_size()
        {
            return Size;
        }
        public override double Area()//метод для визначення площі
        {
            return Size * Size;
        }

       
        public override void Move(double dx, double dy)// метод для переміщення
        {
            X += dx;
            Y += dy;
        }
        public override void Scale(double factor)//метод для зміни розміру
        {
            Size *= factor;
        }

        public override void Rotate(double angle)
        {
            // Квадрати не змінюються при розвороті
        }
    }
}
