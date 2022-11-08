using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();
            try
            {
                //asking user for input
                Console.WriteLine("Select a number:");
                string Entry = Console.ReadLine();
                int Entry1 = Convert.ToInt32(Entry);
                Console.WriteLine("Select another number (optional):");
                string Entry2 = Console.ReadLine();
                if (Entry2 != "")
                {
                    int x = Convert.ToInt32(Entry2);

                    Console.WriteLine(maths.optP(Entry1,x));
                    Console.ReadLine();
                }
                else
                {

                    Console.WriteLine(maths.optP(Entry1));
                    Console.ReadLine();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured.");
                Console.ReadLine();
            }




        }
    }
}
