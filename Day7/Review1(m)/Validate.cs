using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1_m_
{
    public class Validate
    {
        // Declare a delegate with string parameter and void return type
        public delegate void MyValid(string s);

        // Declare an event of type MyValid
        public event MyValid Print;

        // Define a method to check the validity of a string
        public void checkValid(string s)
        {
            // Display a message
            Console.WriteLine("Checking the validity of {0}", s);

            // Invoke the event with the string as argument
            Print(s);
        }

        // Define a method to check the length of a string
        public void check(string s)
        {
            // Associate the event with a delegate that checks the length of a string
            Print += (string str) =>
            {
                if (str.Length == 5)
                {
                    Console.WriteLine("{0} is valid", str);
                }
                else
                {
                    Console.WriteLine("{0} is not valid", str);
                }
            };

            // Call the checkValid method with the string as argument
            checkValid(s);
        }
    }
}