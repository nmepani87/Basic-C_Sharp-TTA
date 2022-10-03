using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() {
                new Employee { FirstName = "Joe", LastName = "Jones", ID = 1 },
                new Employee { FirstName = "Curtis", LastName = "Jones", ID = 2 },
                new Employee { FirstName = "Harry", LastName = "Kane", ID = 3 },
                new Employee { FirstName = "Jordan", LastName = "Henderson", ID = 4 },
                new Employee { FirstName = "James", LastName = "Milner", ID = 5 },
                new Employee { FirstName = "Joe", LastName = "Hart", ID = 6 },
                new Employee { FirstName = "Harvey", LastName = "Elliot", ID = 7 },
                new Employee { FirstName = "Phil", LastName = "Foden", ID = 8 },
                new Employee { FirstName = "Jude", LastName = "Bellingham", ID = 9 },
                new Employee { FirstName = "Bukayo", LastName = "Saka", ID = 10 }
                };


            foreach (var employee in employees)
                if (employee.FirstName.Contains("Joe"))
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
                }
            Console.ReadLine();

            // Using lambda expresss to search for Employee with Joe and done above
            foreach (Employee employee in employees.FindAll(x => x.FirstName == "Joe"))
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
            }
            Console.ReadLine();

            // Search using lambda for employee with id greater than 5
            foreach (Employee employee in employees.FindAll(y => y.ID > 5))
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
            }
            Console.ReadLine();
        }
    }
}
