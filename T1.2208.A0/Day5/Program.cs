using Day5;

int n1 = 5;
int n2 = 0;
try
{
	if (n2 == 0)
	{
		throw new MyException("Loi chia 0");
	}
	else
	{
        int rs = n1 / n2;
        Console.WriteLine($"The result: {rs}");
    }
}
catch (Exception e)
{
	Console.WriteLine(e.Message);
}
Console.WriteLine("DONE");