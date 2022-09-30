using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Multi_Parameters
{
    internal class Average
    {
        // Adding 1 fixed parameter to pass through plus setting
        // creating 2nd optional parameter with default value
        public int AverageTemp(int userinput1, int userinput2 = 0)
        {
            // Doing a sum with the values giving the returning result to outside method
            int averageresult = (userinput1 + userinput2) / 2 ;
            return averageresult;
        }
    }
}
