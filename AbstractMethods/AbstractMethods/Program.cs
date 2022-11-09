using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods
{
    public class Program
    {
        static void Main(string[] args)
        {

            //instantiating a employee object
            Employee employee = new Employee();
            //using polymporhism to create an object of type IQuittable
            IQuittable quittable = new Employee();

            //calling a superclass method
            employee.SayName();
            //calling the Quit() method with the polymorphic object
            quittable.Quit();
        }
    }
} 
