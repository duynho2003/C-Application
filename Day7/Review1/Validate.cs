using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    public delegate void MyValid(string s);
    public class Validate
    {
        public event MyValid Print;
        public void CheckValid(string s)
        {
            Console.WriteLine(s);
        }

        public void Check(string s)
        {
            if (Print != null) 
            { 
                Print(s);
            }
        }
    }
}
