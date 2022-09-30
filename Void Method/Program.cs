using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating new object and assigning to variable
            Temperature temperature = new Temperature();
            // Giving values to two integer variables
            int intinput1 = 66;
            int intinput2 = 13;
            // Passing these variables into the method
            temperature.AverageTemp(intinput1, intinput2);
            Console.ReadLine();
        }
    }
}
