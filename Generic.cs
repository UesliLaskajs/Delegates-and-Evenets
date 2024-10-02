using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{

    
    internal class Generic
    {
        public static void GenericMeth<T>(T[] array)//Generic Method that gets and initialises any Type with <T>
        {
            foreach(T item  in array)
            {
                Console.WriteLine(item);
            }
        }
    }

    
}
