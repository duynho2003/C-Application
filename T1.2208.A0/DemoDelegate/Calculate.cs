using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    //khai báo  delegate 
    public delegate int CalcDelegate(int a, int b);
    internal class Calculate
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("ADD");
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            Console.WriteLine("SUB");
            return a - b;
        }
    }
}
