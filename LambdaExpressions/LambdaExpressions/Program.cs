using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> Newlist = new List<Employee>();
            //Creating a list of employees, two of which with duplicate first names.
            Employee employee = new Employee();

            List<Employee> Employees = new List<Employee>
            {
                new Employee{firstName="Alex", lastName="Clark", Id=1 },
                new Employee{firstName="Andy", lastName="Clark", Id=2 },
                new Employee{firstName="Al", lastName="Clark", Id=3 },
                new Employee{firstName="Amy", lastName="Clark", Id=4 },
                new Employee{firstName="Anthony", lastName="Clark", Id=5 },
                new Employee{firstName="Adam", lastName="Clark", Id=6 },
                new Employee{firstName="Addie", lastName="Clark", Id=7 },
                new Employee{firstName="Joe", lastName="Clarky", Id=8 },
                new Employee{firstName="Joe", lastName="Clark", Id=9 },
                new Employee{firstName="Mike", lastName="Clark", Id=10 }
            };

            //List<Employee> Employees = new List<Employee>
            //{
            //    new Employee("Andy", "clark", 5)
            //    //new Employee{firstName="Andy", lastName="Clark", Id=2 },
            //    //new Employee{firstName="Al", lastName="Clark", Id=3 },
            //    //new Employee{firstName="Amy", lastName="Clark", Id=4 },
            //    //new Employee{firstName="Anthony", lastName="Clark", Id=5 },
            //    //new Employee{firstName="Adam", lastName="Clark", Id=6 },
            //    //new Employee{firstName="Addie", lastName="Clark", Id=7 },
            //    //new Employee{firstName="Joe", lastName="Clarky", Id=8 },
            //    //new Employee{firstName="Joe", lastName="Clark", Id=9 },
            //    //new Employee{firstName="Mike", lastName="Clark", Id=10 }
            //};

            //Employees.ForEach(Console.WriteLine);
            foreach (Employee emp in Employees) //for each employee, check if joe is a name and if it is, add it to new list
            {
                if (emp.firstName == "Joe")
                {
                    Newlist.Add(emp);
                }
            }
            // a foreach loop that writes out each item in the Newlist
            foreach (Employee joe in Newlist)
            {
                Console.WriteLine(" {0} {1} {2}", joe.firstName, joe.lastName, joe.Id);                
            }
            Console.ReadLine();

            // a lambda expression that creates a newlist 'joeList' of type Employee, and then 
            // checks certain parameters from list 'Employees'. if those parameters are met, then
            // the items are added to the new 'joeList' list. The frist x represents all the items in
            // the 'Employees' list, and then the => tells it to check the parameters found to the right.
            // x.firstName tells it which property of the object x to check, and then to add to 'joeList'
            // if the parameters are met.
            List<Employee> joeList = Employees.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee joe in joeList)
            {
                Console.WriteLine(" {0} {1} {2}", joe.firstName, joe.lastName, joe.Id);
            }
            Console.ReadLine();

            // a lambda expression that creates a newlist 'IdOver5' of type Employee, and then 
            // checks certain parameters from list 'Employees'. if those parameters are met, then
            // the items are added to the new 'IdOver5' list.
            List<Employee> IdOver5 = Employees.Where(c => c.Id > 5).ToList();

            foreach (Employee joe in IdOver5)
            {
                Console.WriteLine(" {0} {1} {2}", joe.firstName, joe.lastName, joe.Id);
            }
            Console.ReadLine();



        }
    }
}
