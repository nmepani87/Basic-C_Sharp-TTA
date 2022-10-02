using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiat object and giving values to properties
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };


            // Running the overriden method within the object 
            employee.SayName();
            
            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}
