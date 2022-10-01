using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object and giving values to properties
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            // Running method within the superclass of the objects class
            employee.SayName();
        }
    }
}
