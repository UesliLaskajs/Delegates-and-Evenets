using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    public delegate void Notify(string message);//Delegate that passes a method
    public class Events
    {
        public event Notify OnNotify;//Create an Event with the delegate tyoe

        public void RaiseEvent(string message)//Raise an Event
        {
            OnNotify?.Invoke(message);//Invoke the message from the event if it is triggered
        }

    }

    public class Subcriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine(message);
        }

    }
}
