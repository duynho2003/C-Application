using Day7;

MyFunc mf = delegate(string s) { return s.Length; };

int Test1(string s)
{ 
    return s.Length; 
};

mf = Test1;

mf  = s => s.Length;

string s = "Welcome T1.2208.A0 class";
Console.WriteLine($"Result: {s.MyCase()}");

// tạo đối tượng có kiểu
var stu = new Student { Id = 1, Name = "Quang", Email = "quang@gmail.com" };

stu.Birthday = DateTime.Now;
stu.Gender = true;

// tạo đối tượng thuộc loại anonymous type
var stu2 = new { Id = 2, Name = "Thuy", Email = "thuy@gmail.com" };

// demo nullable type
Nullable<int> m = null;
int? n = 6;
if (n.HasValue)
{
    Console.WriteLine("n has value");
    Console.WriteLine($"n = {n!}");
}
else
{
    Console.WriteLine("n has not value");
}

int k = n.HasValue ? n.Value : 0;
int l = n ?? 0;