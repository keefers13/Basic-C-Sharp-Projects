using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        

        string[] names = { "Kroos > ", "Modric > ", "Valverde > " };
        Console.WriteLine("Input the name of a famous midfielder:");
        string stringEntry = Console.ReadLine();

        for (int n = 0; n < names.Length; n++)
        {
            names[n] = names[n] + stringEntry;
        }

        foreach(string name in names)
        {
            Console.WriteLine(name);            
        }
        Console.ReadLine();

        //infinite loop and fix
        int count = 0;

        while (true)
        {
            Console.WriteLine("Count = {0}.", count);
            //added this to the loop so the count would increase and meet the condition below.
            count++;

            // ...

            if (count > 10)
            {
                break;
            }
        }
        Console.ReadLine();

        int num = 0;

        while (true)
        {
            Console.WriteLine("Number = {0}.", num);
            num++;

            // ...

            if (10 > num)
            {
                break;
            }
        }
        Console.ReadLine();

        int age = 0;

        while (true)
        {
            Console.WriteLine("Age = {0}.", age);
            age++;

            // ...

            if (30 <= age)
            {
                break;
            }
        }
        Console.ReadLine();

        //list of strings with unique items
        List<string> letters = new List<string>() { "A", "B", "C", "D", "E" };
        Console.WriteLine("Guess an early letter in the Alphabet (for example - A ):");
        string guess = Console.ReadLine();

        for (int i = 0; i < letters.Count; i++)
        {
            if (guess == letters[i])
            {
                Console.WriteLine($"Index: {i}. Letter: {letters[i]}");
            }
            else if (!letters.Contains(guess))
            {
                Console.WriteLine("That letter isn't early enough in the Alphabet");
                break;
            }
            
        }

        // string list with identical items
        List<string> states = new List<string>() {"Alaska", "Washington", "Oregon", "California", "Hawaii", "Hawaii"};
        Console.WriteLine("Guess a state that borders the pacific ocean:");
        string guessState = Console.ReadLine();

        for (int i = 0; i < states.Count; i++)
        {
            if (guessState == states[i])
            {
                Console.WriteLine($"Index: {i}. State: {states[i]}");
            }
            else if (!states.Contains(guessState))
            {
                Console.WriteLine("That state doesn't border the pacific ocean.");
                break;
            }



        }
        Console.ReadLine();

        //list of strings with duplicates
        List<string> myNames = new List<string>() { "Keith", "Alan", "Moore", "Moore" };
        List<string> readNames = new List<string>();
        
        // a loop to check if items from the first list are present in the second,
        // catching the duplicates and denoting it with the appropriate concatenation
        foreach (string name in myNames)
        {
            if (readNames.Contains(name))
            {
                readNames.Add(name);
                Console.WriteLine(name + ": this name is a duplicate.");
            }
            else
            {
                readNames.Add(name);
                Console.WriteLine(name + ": this name is unique.");
            }

        }

        Console.ReadLine();










    }

}
