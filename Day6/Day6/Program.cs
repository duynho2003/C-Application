using Day6;
using System.Collections;

MyArray<int> list = new MyArray<int>();


list.Add(1);
list.Add(2);
list.Add(7);
//list.Add("6");
list.Add(9);
list.Add(15);
list.Add(4);

for (int i = 0; i < list.Count; i++) 
{
    int n = list[i]!;
    Console.WriteLine(n);
}

foreach (int n in list)
{
    Console.WriteLine(n);
}

Console.WriteLine("Done.");