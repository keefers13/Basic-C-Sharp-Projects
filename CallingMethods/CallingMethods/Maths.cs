using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Maths
    {   // creating three methods that have the userEntry int passed in
        public static void fiveMethod(int userEntry)
        {
            int plusFive = userEntry + 5;
            Console.WriteLine("Your number plus 5 is " + plusFive);
            Console.ReadLine();
        }

        public static void sixMethod(int userEntry)
        {
            int plusSix = userEntry + 6;
            Console.WriteLine("Your number plus 6 is " + plusSix);
            Console.ReadLine();
        }

        public static void sevenMethod(int userEntry)
        {
            int plusSeven = userEntry + 7;
            Console.WriteLine("Your number plus 7 is " + plusSeven);
            Console.ReadLine();
        }


    }
}
