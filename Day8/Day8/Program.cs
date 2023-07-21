int[] a = { 1, 4, 9, 5, 16, 12, 8 };

ref int Test()
{
    return ref a[2];
}

ref int n = ref Test();
n = 30;

Console.WriteLine($"n = {n}, { a[2]}");
Console.WriteLine("Done");

var tup = Tuple.Create("quang", "quang@gmail.com");
Console.WriteLine(tup.Item1 + " - " + tup.Item2);

var emp = new { Name = "quang", Email = "quang@gmail.com"};
var tup2 = Tuple.Create(emp.Name, emp.Email);