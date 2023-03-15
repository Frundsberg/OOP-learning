using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3_1_
{
    class Program
    {
        static void Main(string[] args)
        {// задамо довільні вхідні значення і викличемо методи для перевірки роботи системи класів 
            // для прямокутника
            double wight = 12;
            double hight = 7.5;
            Rectangle rectangle = new Rectangle(wight,hight);
            double aera1 = rectangle.GetArea();
            double perimeter1 = rectangle.GetPerimeter();
            Convert.ToString(aera1);
            Convert.ToString(perimeter1);
            Console.WriteLine("Площа прямокутника = " + aera1);
            Console.ReadLine();
            Console.WriteLine("Периметр прямокутника = " + perimeter1);
            Console.ReadLine();
            // кола
            double radius = 5.7;
            Circle circle = new Circle(radius);
            double aera2 = circle.GetArea();
            double perimeter2 = circle.GetPerimeter();
    
            Console.WriteLine("Площа кола = " + aera2);
            Console.ReadLine();
            Console.WriteLine("Довжина кола = " + perimeter2);
            Console.ReadLine();
            // трапеції
            double base1 = 4.1;
            double base2 = 8;
            double hight2 = 10;
            double side1 = 7;
            double side2 = 13;
            Trapezium trapezium = new Trapezium(base1, base2, hight2, side1, side2);
            double aera3 = trapezium.GetArea();
            double perimetr3 = trapezium.GetPerimeter();

           
            Console.WriteLine("Площа трапеції = " + aera3);
            Console.ReadLine();
            Console.WriteLine("Периметр трапеції = " + perimetr3);
            Console.ReadLine();
                

        }
    }
}
