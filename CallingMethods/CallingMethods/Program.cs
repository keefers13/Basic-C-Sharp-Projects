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
            Maths maths = new Maths();
            //asking user for a number, and then calling the methods
            //from the Maths class and using that number. 
            Console.WriteLine("Select a number:");
            string Entry = Console.ReadLine();
            int userEntry = Convert.ToInt32(Entry);
            Console.WriteLine(Maths.fiveMethod(userEntry));
            Console.WriteLine(Maths.sixMethod(userEntry));
            Console.WriteLine(Maths.sevenMethod(userEntry));
            Console.ReadLine();



        }
    }
}
