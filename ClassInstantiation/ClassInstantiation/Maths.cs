using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstantiation
{
    public class Maths
    {
        //creating a void method that doesn't return anything
        public void myMethod(int firstEntry,int  secondEntry)
        {
            int answer = firstEntry + 5;
            Console.WriteLine("This was the second number: " + secondEntry);
        }
    }
}
