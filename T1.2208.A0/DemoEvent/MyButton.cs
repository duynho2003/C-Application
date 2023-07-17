using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvent
{
    public delegate void ClickDelegate(string s);
    internal class MyButton
    {
        //khai bao event
        public event ClickDelegate ClickEvent;
        public void Clicked() 
        { 
            if(ClickEvent != null)
            {
                ClickEvent("You are click me ");

            }
        }
    }
}
