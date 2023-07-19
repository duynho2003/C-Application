using Review1;

Account acc = new Account("Quang", 10000);
string? choose = string.Empty;
do
{
    Console.WriteLine("Deposit");
    Console.WriteLine("Withdraw");
    Console.WriteLine("Show");
    Console.WriteLine("Quit");
    Console.Write("Choose: ");
    choose = Console.ReadLine();
    switch (choose)
    {
        case "Deposit":
            {
                Console.Write("Input amount: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                acc.Deposit = amount;
                break;
            }
        case "Withdraw":
            {
                Console.Write("Input amount: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                acc.Withdraw = amount;
                break;
            }
        case "Show":
            {
                acc.Display();
                break;
            }
        default: break;
    }
} while (choose!.ToLower() != "quit");