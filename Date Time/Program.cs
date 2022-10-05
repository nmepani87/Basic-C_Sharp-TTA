using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating new datetime object that contains the date and time at present
            DateTime now = DateTime.Now;
            // writing information to console by converting to a string too
            Console.WriteLine(now.ToString());
            // Asking user question
            Console.WriteLine("Please pick a number:");
            // Assigning input to integer variable by converting it to int  
            int num = Convert.ToInt32(Console.ReadLine());
            // Creating another datetime object that takes now variable info and using AddHours method
            // we use the int variable to be the int added on
            DateTime later = now.AddHours(num);
            // Writing new time to console
            Console.WriteLine(later.ToString());
            Console.ReadLine();
        }
    }
}
