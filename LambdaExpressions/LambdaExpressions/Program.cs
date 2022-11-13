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
            List<Employee> Employees = new List<Employee>();
            List<string> Newlist = new List<string>();
            Employees.Add(new Employee("Alex", "Clark", 1));
            Employees.Add(new Employee("Allie", "Clarksanne", 2));
            Employees.Add(new Employee("Alexandra", "Clarko", 3));
            Employees.Add(new Employee("Andy", "Clarking", 4));
            Employees.Add(new Employee("Abby", "Clarked", 5));
            Employees.Add(new Employee("Abbie", "Clarkin", 6));
            Employees.Add(new Employee("Adam", "Clarks", 7));
            Employees.Add(new Employee("Arnold", "Clarky", 8));
            Employees.Add(new Employee("Joe", "Clark", 9));
            Employees.Add(new Employee("Joe", "Clarkson", 10));

            Employees.ForEach(Console.WriteLine);
            Console.ReadLine();
            //foreach (string emp in Employees) //for each employee, check if joe is a name and if it is, add it to new list
            //{
            //    if (emp == "Joe")
            //    {
            //        Newlist.Add(emp);
            //    }
            //}




            ////Creating a list of employees, two of which with duplicate first names.
            //Employee employee = new Employee();

            //List<Employee> Employees = new List<Employee>
            //{
            //    new Employee{firstName="Alex", lastName="Clark", Id=1 },
            //    new Employee{firstName="Andy", lastName="Clark", Id=2 },
            //    new Employee{firstName="Al", lastName="Clark", Id=3 },
            //    new Employee{firstName="Amy", lastName="Clark", Id=4 },
            //    new Employee{firstName="Anthony", lastName="Clark", Id=5 },
            //    new Employee{firstName="Adam", lastName="Clark", Id=6 },
            //    new Employee{firstName="Addie", lastName="Clark", Id=7 },
            //    new Employee{firstName="Joe", lastName="Clark", Id=8 },
            //    new Employee{firstName="Joe", lastName="Clark", Id=9 },
            //    new Employee{firstName="Mike", lastName="Clark", Id=10 }
            //};

            //Employees.ForEach(Console.WriteLine);
            //Console.ReadLine();

            //List<string> Newlist = new List<string>();

            //foreach (Employee Employee in Employees)
            //{
            //    if (Employee.firstName == "Joe")
            //    {
            //        Newlist.Add(Employee.firstName);
            //    }
            //}

            //Newlist.ForEach(Console.WriteLine);
            //Console.ReadLine();

            //List<string> joeList = Employees.Where(x => x == "Joe").ToList();

            //List<Employee> IdOver5 = Employees.Where(c => c.Id > 5).ToList();


        }
    }
}
