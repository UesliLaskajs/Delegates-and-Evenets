using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    public delegate void  Alert (string message);//Create a Delegate wich later you will add a method

    internal class TempratureEvent
    {
        public event Alert OnAlert;//Create the event with the type of delegate

        private int _temprature;//Temprature field

        public int Temprature { get { return _temprature; }//Property to manipulate the temp and raise the event if temp input changes
            set { _temprature = value;
            if(_temprature > 30)
                {
                    RaiseAlert("Warning:Temprature is above 30 degrees");//Triggers Event and passes this message if temp is changed
                }
            }
        }

        public void RaiseAlert(string message) { //the method that The Event invokes its parameter
            OnAlert.Invoke(message);
        }
    }

    public class UserInputs
    {
        public void UserInputMessage(string message)//The Delegate to be passed wich will hold the message of the event
        {
            Console.WriteLine(message);
        }
    }
}
