using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload
{
    internal class Classes
    {
        // Void method takes in and out a parameter
        public void Number(int intinput1, out int total)
        {
            // simple math done on parameter passed through
            total = intinput1 / 2;
        }

        // Void static method takes in and out a parameter
        public void Number(int intinput1, int intinput2, out int total)
        {
            // simple math done on parameter passed through
            intinput2 = 0;
            total = intinput1 + intinput2;
        }

       
    }
}
