using System;

namespace while_and_do_while_statements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess my favorite number between 1-13");
            int favNum = Convert.ToInt32(Console.ReadLine());
            bool guessed = false;

            while (!guessed)
            {
                switch (favNum)
                {
                    case 1:
                        Console.WriteLine("Nope! Try again.");
                        Console.WriteLine("Guess a number between 1-13");
                        favNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("You are right! My favorite number is 13!");
                        guessed = true;
                        break;
                    default:
                        Console.WriteLine("Nope! Try again.");
                        Console.WriteLine("Guess a number between 1-13");
                        favNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.ReadLine();
            }
            
            Console.WriteLine("Guess which number between 1 - 7 belongs to Friday!");
            int number = Convert.ToInt32(Console.ReadLine());
            int day = number;
            bool isGuessed = false;
            do
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("No, this is Monday");
                        Console.WriteLine("Guess a Number between 1 and 7!");
                        Console.WriteLine();
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("No, this is Tuesday");
                        Console.WriteLine("Guess a Number between 1 and 7!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("No, this is Wednesday");
                        Console.WriteLine("Guess a Number between 1 and 7!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine(" Nno, this is Thursday");
                        Console.WriteLine("Guess a Number between 1 and 7!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Yes, this is Friday!");
                        isGuessed = true;
                        break;
                    case 6:
                        Console.WriteLine("No, this is Saturday");
                        Console.WriteLine("Guess a Number between 1 and 7!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("No, this is Sunday");
                        Console.WriteLine("Guess a Number between 1 and 7!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
