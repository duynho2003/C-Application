using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoStudent
{
    public class Student
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime Birthday { get; set; }

        public Student() { }

        public void Input()
        {
            string idPat = @"STU\d\d\d\d";
            Regex reg = new Regex(idPat);

            while (true) {
                Console.WriteLine("Input Student ID: ");
                string? id = Console.ReadLine();
                if (reg.IsMatch(id!))
                {
                    Id = id;
                    break;
                }
                Console.WriteLine("Student Id has format: STU0000");

            }

            Console.WriteLine("Input Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Input Email: ");
            Email = Console.ReadLine();

            Console.WriteLine("Input Birthday (yyyy-mm-dd): ");
            Birthday = DateTime.Parse(Console.ReadLine()!);


        }
        public override string ToString()
        {
            string sBirthday = Birthday.ToShortDateString();
            return $"ID: {Id} - Name: {Name} - Birthday: {sBirthday}";
         }
    }
}