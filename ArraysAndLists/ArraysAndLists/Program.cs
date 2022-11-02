using System;
using System.Collections.Generic;

class Program
{
     static void Main()
     {

        string[] stringArray = { "hi", "hello", "hola", "hallo" };
        int[] numArray = { 5, 2, 10, 200, };
        List<string> stringList = new List<string>();
        stringList.Add("Merry Christmas");
        stringList.Add("Happy Holidays");
        stringList.Add("Feliz Navidad");
        stringList.Add("Muy Felices Fiestas");



        //string array query and response
        Console.WriteLine("Please enter a number between 0 and 3");
        string stringEntry = Console.ReadLine();
        int stringIndex = Convert.ToInt32(stringEntry);
        if (stringIndex > 3)
        {
            Console.WriteLine("Sorry, that number index in the array doesn't exist.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(stringArray[stringIndex]);
            //int array query and response
            Console.WriteLine("Thank you! Again, please enter a number between 0 and 3");
            string numEntry = Console.ReadLine();
            int numIndex = Convert.ToInt32(numEntry);

            if (numIndex > 3)
            {
                Console.WriteLine("Sorry, that number index in the array doesn't exist.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(numArray[numIndex]);
                Console.ReadLine();
                //stringList query and response
                Console.WriteLine("Thank you! Again, please enter a number between 0 and 3");
                string listEntry = Console.ReadLine();
                int listIndex = Convert.ToInt32(listEntry);

                if (listIndex > 3)
                {
                    Console.WriteLine("Sorry, that number index in the array doesn't exist.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(stringList[listIndex]);
                    Console.ReadLine();
                }

            }

        }



    }

}
