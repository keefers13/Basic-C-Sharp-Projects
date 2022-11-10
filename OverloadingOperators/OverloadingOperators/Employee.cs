using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    public class Employee
    {
        //overloading the == operator to return a bool statement after comparing two ID's
        public static bool operator == (Employee ID1, Employee ID2)
        {
            Console.WriteLine("Comparing Id's are the same");
            return ID1.ID == ID2.ID;
            
        }
        //overloading the != operator to return a bool statement after comparing two ID's
        public static bool operator != (Employee ID1, Employee ID2)
        {
            Console.WriteLine("Comparing Id's are not the same");
            return ID1.ID != ID2.ID;
        }

        public int ID = 0;
        public string FirstName = "Sample";
        public string LastName = "Student";
    }
}
