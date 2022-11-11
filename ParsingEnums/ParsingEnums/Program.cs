using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week (example \"Monday\")");
            string daySelected = Console.ReadLine();

            try //try/catch block that runs the code and ensures correct inupt
            {
                //Assigning the value to the variable of the enum data type 
                
                DaysoftheWeek day = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek), daySelected); 
                // ensuring user input is part of the data defined in the enum 
                if (Enum.IsDefined(typeof(DaysoftheWeek), day))
                {
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }

            }

            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
            }



        }
    }



}
