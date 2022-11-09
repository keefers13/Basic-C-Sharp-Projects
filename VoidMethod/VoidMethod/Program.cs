using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public static class Program
    {
        //made this method static
        public static void Main(string[] args)
        {
            //instantiating the method from class Maths
            Maths maths = new Maths();

            //asking for user input
            Console.WriteLine("Select a number:");
            string Entry = Console.ReadLine();
            int Entry1 = Convert.ToInt32(Entry);

            //displaying the user input to the screen, divided by two
            maths.myMethod(Entry1, out int answer);
            Console.WriteLine(answer);
            Console.ReadLine();
             //asking for user input
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //calling on an overloaded method to display user input
            maths.myMethod(name);


        }
    }
}
