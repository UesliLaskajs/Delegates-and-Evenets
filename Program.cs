namespace Events_and_Delegates
{
    internal class Program
    {

        public delegate void Notify(string message);//This is a Delegate wich passed as Argument Methods
        static void Main(string[] args)
        {
            Notify notify = DisplayMsg;//Passing a method to Delegate Parameter
            notify("Hello,Comrade");


            Delegates_and_Event logger = new Delegates_and_Event();//Initiated the class wich holds the methods
            EventDelegate delegates = logger.MessageConsole;//Initiated the Delegate and Added method from class logger
            delegates += logger.MessagePrint;//This is A multicast delegate wich holds reference for multiple methods
            delegates -= logger.MessageConsole;
            
            bool result =Delegates_and_Event.IsMethodDelegate(delegates, logger.MessagePrint);

            if (result) {
               
                logger.MethodInvoking(logger.MessagePrint,"Method Succesfully Invoked");
                delegates("Hello");
            }
            else
            {
                Console.WriteLine("Method Not Found");
            }


            logger.MethodInvoking(logger.MessageConsole, "After Removing message Console");
           
           


      
            int[] integerArr = { 1, 2, 3, 4, 5 };
            string[] strArr = { "one", "two", "three" };

            Generic.GenericMeth(integerArr);//It is static so no need to create an instance of an object
            Generic.GenericMeth(strArr);

            /////////////////////////////////////////////////

            Person[] person =               //Created The Person Array with 2 fields
            {
            new Person {Name="Uesli",Age=20},
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Denis", Age= 36}
            };

            PersonSorter sorterClass = new PersonSorter();//Instantiated The SortedClass 
            sorterClass.Sort(person, compareByAge);//Sort Method from Sorter Class wich passes the Person Array and Generic Method created down Below

            static int compareByAge(Person x, Person y)//Generic method wich will be passed
            {
                return x.Age.CompareTo(y.Age);
            }

            static int CompareByName(Person x, Person y)
            {
                return x.Name.CompareTo(y.Name);
            }

            foreach (Person p in person)//Console after Method
            {
                Console.WriteLine($"Age:{p.Age} and Name:{p.Name}");
            }


            ////////////////////Events///////////////////
            ///
            Events publisher = new Events();
            Subcriber sub = new Subcriber();
            publisher.OnNotify += sub.OnEventRaised;
            publisher.RaiseEvent("Event Raised");

            ///////////////////Event2/////////////
            //

            TempratureEvent temp=new TempratureEvent();
            UserInputs user=new UserInputs();

            temp.OnAlert += user.UserInputMessage;

            temp.Temprature = 31;






            Console.ReadKey();
        }

        static void DisplayMsg(string message)
        {
            Console.WriteLine(message);
        }
        

        
     
        
    }
}
