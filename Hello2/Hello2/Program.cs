using System.Globalization;

Console.Write("Input your name: ");  //xuat chuoi ma khong xuong hang
string name = Console.ReadLine(); //nhan 1 chuoi tu ban phim
Console.WriteLine("Your name is:" + name);  //xuat chuoi ma xuong hang
Console.WriteLine("Your name is: {0}", name);  //xuat chuoi ma xuong hang
Console.WriteLine("Your name is: {0}, {1}", name, 20);
int age ;
Console.Write("Input your age: ");
string s = Console.ReadLine();
age = Convert.ToInt32(s);
string ss = $"Your name is: {name}, {age}";
Console.WriteLine(ss);