using DemoEvent;
using System.Collections;

MyButton btn = new MyButton();
//btn.ClickEvent += Btn_ClickEvent;

//void Btn_ClickEvent(string s)
//{
//    Console.WriteLine(s);
//}

//subcriber method to listen event
btn.ClickEvent += s => Console.WriteLine(s);
btn.Clicked();
Console.WriteLine("DONE");

Hashtable hashtable = new Hashtable();
hashtable["abc"] = "123";
hashtable.Add("abcd", "145");
