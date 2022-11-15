using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a constant variable on myName
            const string myName = "Keith";
            // creating an implicit variable of myFavTeam
            var myFavTeam = "Real Madrid Football Club";
            // writing those two variables to the console
            Console.WriteLine("My name is {0} and my" +
                " favorite sports team is {1}.", myName, myFavTeam);
            Console.ReadLine();

            //creating an object 'roster' of type or class 'Roster', which requires at least two variables.
            //If only two are given, then it triggers the chained constructors below to auto-input the third variable.
            Roster roster = new Roster("Midfield", 8);
            Console.WriteLine("First player on the roster is {0}, who plays {1}, and is number {2}.", roster.Name, roster.Postion, roster.Number);
            Console.ReadLine();
        }
        //creating public class 'Roster'
        public class Roster
        {
            //creating three properties for the class
            public string Postion { get; set; }
            public int Number { get; set; }
            public string Name { get; set; }
            
            //creating a constructor chain for the below constructor, which will allow 
            //any objects of this class created to only have the first two paramters
            //required above, as there will be the option for the third, 'name', to be auto-filled as "Toni Kroos"
            public Roster(string position, int num) : this(position, num, "Toni Kroos")
            {

            }
            //creating a contstructor for the class
            public Roster(string position, int num, string name)
            {
                Postion = position;
                Number = num;
                Name = name;
            }
        }
    }
}
