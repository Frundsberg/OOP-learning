using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    class Rectangle : Figure // клас прямокутника
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double x, double y, double width, double height) 
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public override double Area() // метод для знаходження площі
        {
            return Width * Height;
        }

        public double getx()// гетери
        {
            return X;
        }
        public double gety()
        {
            return Y;
        }
        public double getw()
        {
            return Width;
        }
        public double geth()
        {
            return Height;
        }
       
        public override void Move(double dx, double dy)// метод для переміщення координатів центру
        {
            X += dx;
            Y += dy;
        }

        public override void Scale(double factor) // метод для зміни розмірів
        {
            Width *= factor;                     //ширина
            Height *= factor;                    //висота
        }

        public override void Rotate(double angle)// метод для розвороту на заданий кут
        {
            double radians = angle * Math.PI / 180.0; // для координат центру фігури
            double cos = Math.Cos(radians);
            double sin = Math.Sin(radians);

            double newX = X * cos - Y * sin;
            double newY = X * sin + Y * cos;

            X = newX;
            Y = newY;
        }
    }
}
