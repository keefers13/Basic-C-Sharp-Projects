using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //a try catch block and a while loop catching exceptions that are thrown.
            try
            {
                bool validEntry = false;
                int userAge = 0;
                while (!validEntry)
                {
                    Console.WriteLine("Please enter your age:");
                    validEntry = int.TryParse(Console.ReadLine(), out userAge);
                    if (!validEntry)
                    {
                        Console.WriteLine("Please enter whole digits only");
                    }
                    else if (userAge < 1)
                    {
                        
                        Console.WriteLine("You did not enter a whole number with a value greater than 0");
                        Console.ReadLine();
                        //ensuring the while loop continues if they haven't entered a whole number above 0
                        validEntry = false;
                    }
                    else
                    {
                        Console.WriteLine("Your age is {0}", userAge);
                        Console.ReadLine();
                        return;
                    }
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a whole number between 1 - 150 (example: 15): ");
                Console.ReadLine();
            }
        }
    }
}
