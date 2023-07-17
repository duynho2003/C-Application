using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Shape
    {
       protected int boderSize;
        public string Color { set; get; }
        public Shape()
        {
            Console.WriteLine("This is shape default constructor");
            Color = "red";
        }

        public Shape(string color)
        {
            Console.WriteLine("This is shape parameters constructor");
            Color = color;
        }

        public virtual void Draw()
        {
            Console.WriteLine(Color);
        }

        public void Print()
        {
            Console.WriteLine("This is Sharp.Print() method");
        }
    }
}
