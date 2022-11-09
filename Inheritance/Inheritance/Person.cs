using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //creating a parent class
    public class Person
    {
        public string FirstName = "Sample";
        public string LastName = "Student";

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
