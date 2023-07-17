using DemoDelegate;

Calculate cal = new Calculate();
//tao doi tuong CalcDelegate, truyeen vao ham can goi
CalcDelegate calcDele = new CalcDelegate(cal.Add);
//CalcDelegate calDele2 = cal.Add;
int a = 6;
int b = 3;
int rs = calcDele(a, b);
//Console.WriteLine(rs);

calcDele = Calculate.Sub;
//rs += calcDele(a, b);
//Console.WriteLine(rs);

//su dung anoymous method
calcDele += delegate(int a, int b) {  return a * b; };
//rs = calcDele(a, b);
//Console.WriteLine(rs);

//su dung lambda
calcDele += (a, b) => a / b;
rs = calcDele(a, b);
Console.WriteLine(rs);
Console.WriteLine("DONE");