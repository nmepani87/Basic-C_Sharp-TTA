using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Employee : Person, IQuittable
    {
        // Overridding method thats in the superclass
        public override void SayName()
        {
            // Printing object value and strings to console 
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
            return;
        }
        public void Quit()
        {
            Console.WriteLine("This program will shut down after a few presses on the enter/return key");
            Console.ReadLine();
        }
    }
}
