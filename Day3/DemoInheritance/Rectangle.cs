using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public  class Rectangle: Shape
    {
        public Rectangle(): base("yello"){
            Console.WriteLine("This is Rectangle default constructor");

        }

        public Rectangle(string color):base(color)
        {
            Console.WriteLine($"This is Rectangle paramameter constructor {color}");

        }
        public override void Draw()
        {
            //base.Draw(); //goi den ham Draw() cua lop cha 
        
            Console.WriteLine($"Rectangle {Color}");
       
        }

        public new void Print()
        {
            Console.WriteLine("This is Rectangle.Print() method");
        }
    }
}
