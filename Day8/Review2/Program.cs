using Review2;

string choose = string.Empty;
BookManage bm = new BookManage();
// đăng ký listener
bm.Info += s => Console.WriteLine(s);

do
{
    Console.WriteLine("Create New");
    Console.WriteLine("Find By isSale");
    Console.WriteLine("Find All");
    Console.WriteLine("Exit");
    Console.Write("Choose: ");
    choose = Console.ReadLine();
    switch (choose)
    {
        case "Create New":
            {
                Book book = new Book();
                bm.CreateBook();
                break;
            }
        case "Find By isSale":
            {
                bm.FindByIsSale();
                break;
            }
        case "Find All":
            foreach (Book b in bm)
            {
                b.BookInfo();   
            }
            break;
        default: break;
    }
} while (choose.ToLower() == "exit");