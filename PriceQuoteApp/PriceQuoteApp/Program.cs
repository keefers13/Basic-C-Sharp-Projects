using System;


namespace PriceQuoteApp
{
    class Program
    {
        static void Main()
        {
            // Price Quoting Application
            // Retreiving income data from user 1, and converting it to the correct values
            Console.WriteLine("Wlecome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of your package:");
            string packageEntry = Console.ReadLine();
            int packageWeight = Convert.ToInt32(packageEntry);
            string result = packageWeight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Please enter the width of your package below:";
            Console.WriteLine(result);           
            string packageWdth = Console.ReadLine();
            int packageWidth = Convert.ToInt32(packageWdth);
            Console.WriteLine("Please enter the height of your package:");
            string packageHt = Console.ReadLine();
            int packageHeight = Convert.ToInt32(packageHt);
            Console.WriteLine("Please enter the length of your package:");
            string packageLgth = Console.ReadLine();
            int packageLength = Convert.ToInt32(packageLgth);

            double finalPrice = (packageLength * packageHeight * packageWidth) / packageWeight;

            Console.WriteLine("Your estimated total for shipping this package is: $" + finalPrice);
            Console.WriteLine("Thank you!");
            Console.ReadLine();



        }
    }
}
