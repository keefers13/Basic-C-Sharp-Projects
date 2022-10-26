using System;


namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            // Income Comparison Program
            // Retreiving income data from user 1, and converting it to the correct values
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is your hourly rate?");
            string p1hourlyPay = Console.ReadLine();
            int p1hourlyRate = Convert.ToInt32(p1hourlyPay);
            Console.WriteLine("How many hours do you work each week?");
            string p1hoursWeekly = Console.ReadLine();
            int p1hoursWorked = Convert.ToInt32(p1hoursWeekly);
            Console.ReadLine();

            // Retreiving income data from user 2, and converting it to the correct values
            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your hourly rate?");
            string p2hourlyPay = Console.ReadLine();
            int p2hourlyRate = Convert.ToInt32(p2hourlyPay);
            Console.WriteLine("How many hours do you work each week?");
            string p2hoursWeekly = Console.ReadLine();
            int p2hoursWorked = Convert.ToInt32(p2hoursWeekly);
            Console.ReadLine();

            // Using the information from the users to find out their respective salaries, and compare them.
            int p1weeklyWage = p1hourlyRate * p1hoursWorked;
            int p2weeklyWage = p2hourlyRate * p2hoursWorked;
            int p1salary = p1weeklyWage * 52;
            int p2salary = p2weeklyWage * 52;
            bool incomeComparison = p1salary > p2salary;

            // Conveying the data to the users
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(p1salary);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(p2salary);
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine(incomeComparison);
            Console.ReadLine();








        }
    }
}
