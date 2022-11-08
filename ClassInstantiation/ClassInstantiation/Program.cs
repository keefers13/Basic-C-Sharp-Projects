using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstantiation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Maths maths = new Maths();

            Console.WriteLine("Select a number:");
            string Entry = Console.ReadLine();
            int firstEntry = Convert.ToInt32(Entry);
            Console.WriteLine("Select another number:");
            string Entry2 = Console.ReadLine();
            int secondEntry = Convert.ToInt32(Entry2);

            maths.myMethod(firstEntry, secondEntry);
            maths.myMethod(firstEntry: 5, secondEntry: 6);
            Console.ReadLine();

        }
    }
}
