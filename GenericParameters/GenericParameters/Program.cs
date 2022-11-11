using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    public class Program
    {
        static void Main(string[] args)
        {
            //instantiating an object from class Employee, then creating a list of strings 
            //for the property value of property Things in class Employee.
            Employee<string> employeeStr = new Employee<string>();
            employeeStr.Things = new List<string>() { "thing one ", "thing two ", "thing three" };

            //instantiating an object from class Employee, then creating a list of intergers 
            //for the property value of property Things in class Employee.
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int>() { 4, 5, 6 };

            //two loops that run through each item in the lists.
            foreach (var Str in employeeStr.Things) 
            {
                Console.WriteLine(Str);
            }
            foreach (var Int in employeeInt.Things)
            {
                Console.WriteLine(Int);
            }

            Console.ReadLine();
        }
    
    }
}
