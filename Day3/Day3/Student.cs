using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Student
    {
        //khai báo biến
        string id; 
        string name;
        DateTime birthday;

        //khai bao property 
        public string Id
        {
            set { id = value; }
            get { return id; }

        }

        public DateTime Birthday
        {
            set { birthday = value; }   
            get { return birthday; }    
        }

        //khai bao auto property
        public string Name { set; get; }

        public void Inc1Age()
        {
            birthday = birthday.AddYears(1);
        }

        public void Inc1Age(int year)
        {
            birthday = birthday.AddYears(year);
        }


    }
}
