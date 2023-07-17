using System.Net.Http.Headers;

namespace Hello1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 200;
            byte b2 = 100;
            checked
            {
                try
                {
                    byte b3 = (byte)(b1 + b2);
                    Console.WriteLine($"b3 = {b3}");
                }
                catch (OverflowException ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            byte b4  = 200;
            byte b5 = 100;
            unchecked
            {
                byte b6 = (byte)(b4 + b5);
                Console.WriteLine($"b6 = {b6}");
            }
        }
    }
}