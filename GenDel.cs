using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{

    public delegate int Compare<T>(T x, T y);//This Delegate is A passed Method wich uses Generics for Diffrent types 

    public class Person//Class that will be the type for the array
    {
        public string Name {  get; set; }//Field for Name
        public int Age { get; set; }
    }

    public class PersonSorter//Class wich stores the Sort Method
    {
        public void Sort(Person[] person, Compare<Person> compare)//Method that has an argument the Person Array created from class with fields and the Generic that gets the Person Types
        {
            for(int i=0; i<person.Length -1; i++)
            {
                for(int j=i+1;j<person.Length; j++)
                {
                    if (compare(person[i],person[j]) > 0)//The Compare is the method wich will be created when instantiated
                    {
                        Person temp = person[i];
                        person[i] = person[j];
                        person[j] = temp;
                    }
                }
            }
        }
    }

    

}
