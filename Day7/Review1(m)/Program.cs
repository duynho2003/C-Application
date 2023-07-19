using Review1_m_;

// Create object of Account using parameter constructor
Account acc = new Account("John Doe", 1000);
while (true)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Show");
    Console.WriteLine("4. Quit");

    try
    {
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("\nEnter amount to deposit: ");
                int depositAmount = Convert.ToInt32(Console.ReadLine());
                acc.DepositMoney = depositAmount;
                break;

            case 2:
                Console.Write("\nEnter amount to withdraw: ");
                int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                acc.WithdrawMoney = withdrawAmount;
                break;

            case 3:
                acc.Display();
                break;

            case 4:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("\nInvalid choice! Please try again.");
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("\nError: {0}", e.Message);
    }
}