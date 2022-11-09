using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating a employee object
            Employee employee = new Employee();

            //calling a superclass method
            employee.SayName();

            
        }
    }
}
