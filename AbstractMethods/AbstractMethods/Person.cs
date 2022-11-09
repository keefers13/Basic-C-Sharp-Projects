using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods
{
    //creating an abstract class
    public abstract class Person
    {
        public string FirstName = "Sample";
        public string LastName = "Student";

        //creating a virtual method, so that a child class can inherit
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
