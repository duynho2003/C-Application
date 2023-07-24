using Review3;

string choose = string.Empty;
StudentList students = new StudentList();
//dang ki listener

do
{
    Console.WriteLine("Create");
    Console.WriteLine("Find All");
    Console.WriteLine("Find By Mark");
    Console.WriteLine("Exit");
    Console.WriteLine("Nhap su lua chon: ");
    choose = Console.ReadLine()!.Trim();
    Student student = new Student();
    switch (choose)
    {
        case "Create":
            {
                students.Add();
                break;
            }
        case "Find All":
            {
                students.PrintList();
                break;
            }
        case "Find By Mark":
            { 
            Console.Write("Nhap diem ban can tim: ");
            float mark = Convert.ToSingle(Console.ReadLine());
            students.FindByMark(mark);
            break;
            }
        default:
            Console.WriteLine("Lua chon khong hop le!");
            break;
    }
} while (choose.ToLower() != "quit");