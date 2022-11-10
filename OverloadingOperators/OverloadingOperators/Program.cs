using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating two Employee class objects, and giving them ID's
            Employee employee = new Employee() { ID = 1 };
            Employee employee1 = new Employee() { ID = 2 };

            //calling the overloaded operators as methods and writing them to the console.
            Console.WriteLine(employee == employee1);
            Console.WriteLine(employee != employee1);
            Console.ReadLine();



        }
    }
}
