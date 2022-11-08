using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the class
            Maths maths = new Maths();
            //asking user for 3 inputs, an int, decimal, and string, and then calling the methods
            //from the Maths class that use those inputs. 
            Console.WriteLine("Select a number:");
            string Entry = Console.ReadLine();
            int userEntry = Convert.ToInt32(Entry);
            Console.WriteLine("Provide a decimal number:");
            string Entry2 = Console.ReadLine();
            decimal userEntry2 = Convert.ToDecimal(Entry2);
            Console.WriteLine("Select another number:");
            string Entry3 = Console.ReadLine();
            //int userEntry3 = Convert.ToInt32(Entry3);

            Console.WriteLine(maths.mathMethod(userEntry));
            Console.WriteLine(maths.mathMethod(userEntry2));
            Console.WriteLine(maths.mathMethod(Entry3));

            Console.ReadLine();




        }
    }
}
