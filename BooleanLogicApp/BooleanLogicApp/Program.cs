using System;


namespace BooleanLogicApp
{
    class Program
    {
        static void Main()
        {
            // FIguring out whether someone can be approved for car insurance
            // Asking main questions
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            int theirAge = Convert.ToInt32(Age);
            Console.WriteLine("Have you never had a DUI? Reply \"True\" or \"False\".");
            string statusDUI = Console.ReadLine();
            bool DUI = Convert.ToBoolean(statusDUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine();
            int ticketsAccumulated = Convert.ToInt32(speedingTickets);
            Console.WriteLine("Qualified?");
            bool qualified = (theirAge > 15 && DUI && ticketsAccumulated <= 3 );
            Console.WriteLine(qualified);
            Console.ReadLine();

            
        }
    }
}
