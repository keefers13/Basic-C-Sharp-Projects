using System;
using System.Collections.Generic;



class program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 100, 200, 300 };

        // a try/catch block, meant to ensure errors give the correct message 
        // to the user
        try
        {
            // a foreach loop, meant to iterate through each item, divide by the
            // number the user entered, and display the result.
            Console.WriteLine("Please enter a number:");
            int numEntry = Convert.ToInt32(Console.ReadLine());
            foreach (int number in numbers)
            {
                int result = number / numEntry;
                Console.WriteLine(result);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
        Console.WriteLine("You have emerged victorious from the try/catch block!");
        Console.ReadLine();


        // The below code is a basic try/catch block
        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number.");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Please type a whole number");
        //    return;
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("please don't divide by zero");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}
        //Console.ReadLine();
    }
}

