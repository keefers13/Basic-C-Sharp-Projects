using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    public class Maths
    {
        public int optP(int Entry1, int x = 1)
        {
            int answer = Entry1 + x + 5;
            return answer;
        }
    }
}
