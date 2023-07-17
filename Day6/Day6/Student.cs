using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Student
    {
        string name;
        string email;

        public void Print<U>(U s)
        {
            Console.WriteLine(s);
        }
    }
}
