using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main()
        {
            // Daily Report Program
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.ReadLine();

            // asking for an answer that is recieved as a string, then converted to type int
            Console.WriteLine("What page number?");
            string currentPage = Console.ReadLine();
            int pageNumber = Convert.ToInt32(currentPage);
            Console.ReadLine();

            // asking for an answer that is recieved as a string, then converted to type bool
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            string needHelp = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(needHelp);
            Console.ReadLine();

            Console.WriteLine("Where there any positive experiences you'd like to share?\nPlease give specifics.");
            string positiveExp = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to share?\nPlease be specific.");
            string feedback = Console.ReadLine();
            Console.ReadLine();

            // asking for an answer that is recieved as a string, then converted to type int
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hoursNumber = Convert.ToInt32(hoursStudied);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. \nAn instructor will respond to this shortly. \nHave a great day!");
            Console.ReadLine();





        }
    }
}
