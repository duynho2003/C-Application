using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    public class Account
    {
        string? name;
        int balance;
        
        Validate valid = new Validate();

        public Account(string? name, int balance)
        {
            this.name = name;
            this.balance = balance;
            valid.Print += valid.CheckValid; // đăng ký listen method cho event
        }

        public int Deposit
        { 
            set 
            { 
                if (value < 100)
                {
                    valid.Check("Invalid amount for deposit. Please enter other value");
                }
                else 
                {
                    balance += value;
                }
            }
        }

        public int Withdraw
        {
            set
            {
                if (value < 100 || value >= balance)
                {
                    valid.Check("Invalid amount for withdraw. Please enter other value");
                }
                else
                {
                    balance -= value;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Balance:{balance}");
        }
    }
}
