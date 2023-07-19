using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1_m_
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
            valid.Print += valid.checkValid;
        }

        // Using the concepts of properties create properties Deposit money (for balance).
        public int DepositMoney
        {
            get { return balance; }
            set
            {
                if (value < 100)
                {
                    valid.Print += (string message) =>
                    {
                        Console.WriteLine("Invalid amount for deposit. Please enter other value!");
                    };
                    valid.checkValid(value.ToString());
                }
                else
                {
                    balance += value;
                }
            }
        }

        // Using the concepts of properties create properties Withdraw money (for balance):
        public int WithdrawMoney
        {
            get { return balance; }
            set
            {
                if (value < 100 || value >= balance)
                {
                    valid.Print += (string message) =>
                    {
                        Console.WriteLine("Invalid amount for withdraw. Please enter other value!");
                    };
                    valid.checkValid(value.ToString());
                }
                else
                {
                    balance -= value;
                }
            }
        }

        // Create display() method to show account details: name and balance
        public void Display()
        {
            Console.WriteLine("Account Details:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
}
