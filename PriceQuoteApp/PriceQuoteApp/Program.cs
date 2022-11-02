using System;


namespace PriceQuoteApp
{
    class Program
    {
        static void Main()
        {
            // Price Quoting Application
            // Retreiving date from the user
            Console.WriteLine("Wlecome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of your package:");
            string packageEntry = Console.ReadLine();
            int packageWeight = Convert.ToInt32(packageEntry);
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Please enter the width of your package:");
                string packageWdth = Console.ReadLine();
                int packageWidth = Convert.ToInt32(packageWdth);
                Console.WriteLine("Please enter the height of your package:");
                string packageHt = Console.ReadLine();
                int packageHeight = Convert.ToInt32(packageHt);
                Console.WriteLine("Please enter the length of your package:");
                string packageLgth = Console.ReadLine();
                int packageLength = Convert.ToInt32(packageLgth);
                int packageSize = packageLength + packageHeight + packageWidth;
                if (packageSize > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    // Calculating final price and displaying it to the user
                    double finalPrice = (packageLength * packageHeight * packageWidth) * packageWeight / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + finalPrice);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }

            }           

        }
    }
}
