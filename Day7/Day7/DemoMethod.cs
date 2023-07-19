using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public delegate int MyFunc(string s);

    #region abc
    public static class DemoMethod
    {
        // khai báo extension method
        public static string MyCase(this string s)
        {
            return s.ToUpper();        
        }
    }

    public partial class Student
    { 
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
    #endregion
}
