using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    public class DaysintheWeek
    {
        //creating the property Day
        public DaysoftheWeek Day { get; set; }
    }

    public enum DaysoftheWeek //Creating enum for the days and assigning a set value
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }
}
