using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object and giving values to each property within
            Employee employeeA = new Employee
            {
                FirstName = "John",
                LastName = "Smith",
                ID = 1
            };
            // Creating object and giving values to each property within, but leaving ID value same as first objects
            Employee employeeB = new Employee
            {
                FirstName = "Henry",
                LastName = "Smyth",
                ID = 1
            };

            // Running comparision check and printing to console instead of true/false a string dependant on result
            Console.WriteLine(employeeA == employeeB ? "These two people have the same ID" : 
                "The two people being compared don't have the same ID");




        }
    }
}
