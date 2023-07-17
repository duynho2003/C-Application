// See https://aka.ms/new-console-template for more information
using Day3;
Student stu = new Student();
stu.Id = "stu10"; //tuong duong voi viec goi ham set
string id = stu.Id; //tuong duong voi viec goij ham get
stu.Birthday = new DateTime(2000,12,29);
Console.WriteLine("Year: " + stu.Birthday.ToShortDateString());

int n = 4;
stu.Inc1Age(n); //tang tuoi

Console.WriteLine("Year: " + stu.Birthday.ToShortDateString());

int a = 3;

int b = 5;
Console.WriteLine($"a={a}, b = {b}");
Democs d = new Democs();
//d.Swap(ref a, ref b); goi binh thuong 
d.Swap(b:8, a:2); //truyen tham so theo ten
Console.WriteLine($"After swap, a = {a}, b = {b}");
Console.WriteLine($"a={a}, b = {b}");
