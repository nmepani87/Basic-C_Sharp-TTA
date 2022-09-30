using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Multi_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating new object and assigning to variable
            Average average = new Average();
            // Printing string into console that asks user question
            Console.WriteLine("Please enter what the maximum temperature will be today, if unknown enter what you think it will reach");
            // Reading what the inputs into the console, converting that into an integer and storing it to an integer variable
            int userinput1 = Convert.ToInt32(Console.ReadLine());
            // Printing string into console that asks user question
            Console.WriteLine("Please enter what the minimum temperature will be today, if unsure can you leave it blank");
            // Reading what the inputs into the console and storing it to an string variable
            string userinput2 = Console.ReadLine();

            // If users secound input is blank then if block executed
            if (userinput2 == "")
            {
                // Writing a combination of string and int variables into console, plus gives parameters to the method
                Console.WriteLine("The average temperature for today will be " + average.AverageTemp(userinput1) + "°F");
            }
            else
            {
                // If user input isn't blank, input its converted to integer and assigned to a variable
                int userinput2int = Convert.ToInt32(userinput2);
                // Writing a combination of string and int variables into console, plus giving both parameters to the method
                Console.WriteLine("The average temperature for today will be " + average.AverageTemp(userinput1, userinput2int) + "°F");
            }
        }
    }
}
