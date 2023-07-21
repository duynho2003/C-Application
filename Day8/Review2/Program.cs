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
        case "Create":
            {
                Book book = new Book();
                bm.createBook();
                break;
            }
        case "Find":
            {
                bm.findByIsSale();
                break;
            }
        case "FindAll":
            foreach (Book b in bm)
            {
                b.bookInfo();   
            }
            break;
        default: break;
    }
} while (choose.ToLower() == "exit");