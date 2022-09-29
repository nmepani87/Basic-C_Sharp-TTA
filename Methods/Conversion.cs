using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Conversion
    {
        // Creating a method and giving it a parameter (userinput for main program)
        public int Fahrenheit(int userinput)
        {
            // Converting the result of the sum to an integer and assigning to a int variable name
            int CtoF = (Convert.ToInt32(userinput * 9 / 5) + 32);
            // Returning variable so can be used outside class
            return CtoF;
        }

        // Creating a method and giving it a parameter (userinput for main program)
        public int Kelvin(int userinput)
        {
            // Converting the result of the sum to an integer and assigning to a int variable name
            int CtoK = (Convert.ToInt32(userinput + 273.15));
            // Returning variable so can be used outside class
            return CtoK;
        }

        // Creating a method and giving it a parameter (userinput for main program)
        public int Rankine(int userinput)
        {
            // Converting the result of the sum to an integer and assigning to a int variable name
            int RtoK = (Convert.ToInt32(userinput * 9 / 5) + (Convert.ToInt32(491.67)));
            // Returning variable so can be used outside class
            return RtoK;
        }
    }
}
