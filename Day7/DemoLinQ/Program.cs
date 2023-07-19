int[] a = { 1, 5, 2, 6, 4, 8, 15, 7, 9 };

var result = from n in a
             where n %2 == 1        
             select n;

var result2 = a.Where(b => b % 2 == 1);

foreach(var k in result)
{
    Console.WriteLine($"{k} ");
}
Console.WriteLine();