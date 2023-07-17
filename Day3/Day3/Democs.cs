using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Democs
    {
        public static int n; 
        static Democs()
        {
            n = 10;
        }

        public Democs() 
        { 
        
        }

        //ham huy
        ~Democs()
        {

        }

        public void Swap( int a,  int b)
        {
            Console.WriteLine($"In swap a={a}, b = {b}");
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
