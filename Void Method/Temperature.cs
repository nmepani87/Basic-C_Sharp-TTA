using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method
{
    internal class Temperature
    {
        // Void method so no value is returned ( two parameters given)
        public void AverageTemp(int intinput1, int intinput2)
        {
            // sum that uses one of the parameters passed through, but value not returned after
            int total = intinput1 / 2;
            // writing to console the value of the other parameter 
            Console.WriteLine(intinput2);
        }
    }
}
