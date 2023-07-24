using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    public class StudentList
    {
        Dictionary<string, Student> students;

        public StudentList()
        {
            students = new Dictionary<string, Student>();
        }

        public void Add() 
        { 
            Student student = new Student();
            student.Input();
            students.Add(student.Id, student); // add new student to Dictionary
        }

        public void PrintList() 
        {
            foreach (var student in students.Values) 
            { 
                Console.WriteLine(student); // sẽ gọi student.ToString()
            }
        }

        public void FindByMark(float mark)
        {
            foreach (var student in students.Values)
            {
                if (student.Mark == mark)
                {
                    Console.WriteLine(student); // sẽ gọi student.ToString()
                }
            }
        }
    }
}