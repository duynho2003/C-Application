using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    public class Student
    {
        string id;
        string name;
        float mark;
        public string Id 
        {
            get { return id; } 
            set
            {
                // dùng regular expression để validate
                id = value;
            }    
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Mark
        {
            get { return mark; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    mark = value;
                }
                else
                {
                    Console.WriteLine("Diem tu 1-10");
                }
            }
        }

        public void Input()
        {
            // dùng vòng lặp while để người dùng nhập lại cho đến khi đúng
            Console.WriteLine("Input Id: ");
            Id = Console.ReadLine()!;

            Console.WriteLine("Input Name: ");
            Name = Console.ReadLine()!;

            Console.WriteLine("Input Mark: ");
            Mark = Convert.ToSingle(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Id: {id}, Name: {name}, Mark: {mark}";
        }
    }
}