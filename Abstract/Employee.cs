using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Employee : Person
    {
        // Overridding method thats in the superclass
        public override void SayName()
        {
            // Printing object value and strings to console 
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
            return;
        }
    }
}
