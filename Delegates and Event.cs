using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    public delegate void EventDelegate(string message);//Delegate Can get a method as param
    public class Delegates_and_Event//Class
    {
        public void MessageConsole(string message)//Method
        {
            Console.WriteLine("Console:"+message);
        }

        public void MessagePrint(string message)
        {
            Console.WriteLine("Print:");
        }
    }


}
