using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDateTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a single program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plau 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -32;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 311.1111;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            string myName = "Keith";

            int currentAge = 30;

            string yearsOld = currentAge.ToString();

            string studyingStatus = Convert.ToString(isStudying);
            Console.WriteLine(studyingStatus);
            Console.ReadLine();


        }
    }
}
