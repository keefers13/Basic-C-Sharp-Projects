using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Maths
    {   // creating three methods that have the userEntry int passed in
        public static int fiveMethod(int userEntry)
        {
            int plusFive = userEntry + 5;
            return plusFive;
        }

        public static int sixMethod(int userEntry)
        {
            int plusSix = userEntry + 6;
            return plusSix;
        }

        public static int sevenMethod(int userEntry)
        {
            int plusSeven = userEntry + 7;
            return plusSeven;
        }


    }
}
