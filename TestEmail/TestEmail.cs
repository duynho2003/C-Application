using System.Collections;
using System.Security.Principal;

namespace TestEmail
{
    internal class TestEmail
    {
        static void Main(string[] args)
        {
            string choice;
            MailList mailList = new MailList();

            do
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("Enter add, show or quit");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Quit");
                Console.WriteLine("-----------------------------------------------------------------------------");
                choice = Convert.ToString(Console.ReadLine().ToLower());

                switch (choice)
                {
                    case "add":
                        Console.WriteLine("Please Enter new email to add (letters, digits, . and @ are accpeted.)");

                        string? newEmail = Console.ReadLine();

                        mailList.AddEmail = newEmail!;
                        break;
                    case "show":
                        foreach (var item in mailList.GetEmails())
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    case "quit": break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            } while (choice != "quit");
        }
    }
}