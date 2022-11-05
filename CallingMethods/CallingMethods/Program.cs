using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {

            //asking user for a number, and then calling the methods
            //from the Maths class and using that number. 
            Console.WriteLine("Select a number:");
            string Entry = Console.ReadLine();
            int userEntry = Convert.ToInt32(Entry);
            Maths.fiveMethod(userEntry);
            Maths.sixMethod(userEntry);
            Maths.sevenMethod(userEntry);



        }
    }
}
