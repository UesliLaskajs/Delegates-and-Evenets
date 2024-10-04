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
            Console.WriteLine("Print:"+message);

        }

        

        public void MethodInvoking(EventDelegate eventDelegate, string message)
        {
            EventDelegate tempDelegate = eventDelegate;
            if (tempDelegate != null)
            {
                tempDelegate(message);
            }
        }

        public static  bool IsMethodDelegate(EventDelegate deleg,EventDelegate method)
        {
            if (deleg == null)
            {
                return false;
            }

            foreach(var item in deleg.GetInvocationList())
            {
                if (item == (Delegate)method)
                {

                    return true;
                }

                else
                {
                    return false;
                }

            }
            return false;
        }
    }

    


}
