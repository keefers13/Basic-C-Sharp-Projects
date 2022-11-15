using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prints the current Datetime to the consol
            Console.WriteLine(DateTime.Now);
            // asks for user input and converts it to an int
            Console.WriteLine("Please enter a number between 1-10:");
            int entry = Convert.ToInt32(Console.ReadLine());
            // adds the user input to the hour of the current time
            DateTime futureTime = DateTime.Now.AddHours(entry);
            //writes that future time to the console
            Console.WriteLine(futureTime);
            Console.ReadLine();


        }
    }
}
