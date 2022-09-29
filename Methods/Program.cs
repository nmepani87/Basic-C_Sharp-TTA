using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating new object and assigning to variable
            Conversion conversion = new Conversion();
            // Printing string into console that asks user question
            Console.WriteLine("Please enter what the current temperature is in the Celsius scale:");
            // Reading what the inputs into the console, converting that into an integer and storing it to an integer variable
            int userinput = Convert.ToInt32(Console.ReadLine());
            // Giving a certain method within the object the int value to process and storing end result to int variable
            int resultFtemp = conversion.Fahrenheit(userinput);
            // Writing a combination of string and int variables into console
            Console.WriteLine(userinput + "°C converted into Fahrenheit's is " + resultFtemp + "°F");
            // Giving a certain method within the object the int value to process and storing end result to int variable
            int resultKtemp = conversion.Kelvin(userinput);
            // Writing a combination of string and int variables into console
            Console.WriteLine(userinput + "°C converted into Kelvin's is " + resultKtemp + " K");
            // Giving a certain method within the object the int value to process and storing end result to int variable
            int resultRtemp = conversion.Rankine(userinput);
            // Writing a combination of string and int variables into console
            Console.WriteLine(userinput + "°C converted into Rankine's is " + resultRtemp + "°R");
        }
    }
}
