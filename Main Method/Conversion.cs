using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    internal class Conversion
    {
        public int TempChange (int userinput1)
        {
            // Converting the result of the sum to an integer and assigning to a int variable name
            int CtoF = (Convert.ToInt32(userinput1 * 9 / 5) + 32);
            // Returning variable so can be used outside class
            return CtoF;
        }
        public int TempChange(decimal userinput2)
        {
            // Converting the result of the sum to an integer and assigning to a int variable name
            int CtoF = (Convert.ToInt32(userinput2 * 9 / 5) + 32);
            // Returning variable so can be used outside class
            return CtoF;
        }
        public int TempChange(string userinput3)
        {
            int intinput3 = Convert.ToInt32(userinput3);
            // Converting the result of the sum to an integer and assigning to a int variable name
            int v = Convert.ToInt32(intinput3 * 9 / 5) + 32;
            int CtoF = v;
            // Returning variable so can be used outside class
            return CtoF;
        }


    }
}
