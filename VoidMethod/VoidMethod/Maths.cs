using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Maths
    {
        public void myMethod(int Entry1, out int answer)
        {
            answer = Entry1 / 2;
        }
        public void myMethod(string name)
        {
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
