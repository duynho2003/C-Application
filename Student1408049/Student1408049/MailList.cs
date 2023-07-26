using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Student1408049
{
    public delegate void CheckMail(string s);
    internal class MailList
    {
        public event CheckMail CheckEvent;

        ArrayList list = new ArrayList();

        public MailList()
        {
            CheckEvent += Alert;
        }

        public void Alert(string str)
        {
            Console.WriteLine(str);
        }

        public string AddEmail
        {
            set
            {
                string pattern = @"^[A-Za-z0-9.@]+$";

                if (Regex.IsMatch(value, pattern))
                {
                    list.Add(value);
                }
                else
                {
                    if (CheckEvent != null)
                    {
                        CheckEvent("Invalid Email Address");
                    }
                }
            }
        }
        public IEnumerable GetEmails()
        {
            foreach (var email in list)
            {
                yield return email.ToString();
            }
        }
    }
}