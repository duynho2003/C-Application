using System.Collections;
using System.Security.Principal;

namespace Student1408049
{
    internal class TestEmail
    {
        static void Main(string[] args)
        {
            string choice;
            MailList mailList = new MailList();

            do
            {
                Console.WriteLine("Add");
                Console.WriteLine("Show");
                Console.WriteLine("Quit");
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
                        Console.WriteLine("Wrong choice!");
                        break;
                }
            } while (choice != "quit");
        }
    }
}