using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Maths
    {
        // creating three methods that have the userEntry passed in
        public int mathMethod(int userEntry)
        {
            int answer = userEntry + 5;
            return answer;
        }

        public decimal mathMethod(decimal userEntry2)
        {
            decimal round = Decimal.Round(userEntry2);
            int converted = Convert.ToInt32(round);
            int answer2 = converted + 5;
            return answer2;
        }

        public int mathMethod(string Entry3)
        {
            int converted = Convert.ToInt32(Entry3);
            int answer3 =  converted + 5;
            return answer3;
        }


    }
}
