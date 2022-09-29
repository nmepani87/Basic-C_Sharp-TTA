using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
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
            int userinput1 = Convert.ToInt32(Console.ReadLine());
            // Giving a certain method within the object the int value to process and storing end result to int variable
            int result1 = conversion.TempChange(userinput1);
            // Writing a combination of string and int variables into console
            Console.WriteLine(userinput1 + "°C converted into Fahrenheit's is " + result1 + "°F");

            // Printing string into console that asks user question
            Console.WriteLine("Please enter what the current temperature is in the Celsius scale to a minimum of 3 decimal places:");
            // Reading what the inputs into the console, converting that into an integer and storing it to an integer variable
            decimal userinput2 = Convert.ToDecimal(Console.ReadLine());
            // Giving a certain method within the object the int value to process and storing end result to int variable
            int result2 = conversion.TempChange(userinput2);
            // Writing a combination of string and int variables into console
            Console.WriteLine(userinput2 + "°C converted into Fahrenheit's is " + result2 + "°F");

            // Printing string into console that asks user question
            Console.WriteLine("Please enter what the current temperature is in the Celsius scale:");
            // Reading what the inputs into the console, converting that into an integer and storing it to an integer variable
            string userinput3 = Console.ReadLine();
            // Giving a certain method within the object the int value to process and storing end result to int variable
            int result3 = conversion.TempChange(userinput3);
            // Writing a combination of string and int variables into console
            Console.WriteLine(userinput3 + "°C converted into Fahrenheit's is " + result3 + "°F");
        }
    }
}
