using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
  public abstract class  Figure //Батьківськитй клас для фігури
    {
        public abstract double Area();
        public abstract void Move(double dx, double dy);
        public abstract void Scale(double factor);
        public abstract void Rotate(double angle);
   
    }
}
