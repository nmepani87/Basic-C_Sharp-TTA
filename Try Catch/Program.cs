using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creation of list with numbers
                List<int> numlist = new List<int> { 26, 10, 50, 32 };
                Console.WriteLine("Please enter a number for other numbers to be divided by:");
                // Converting to an int what the user enters 
                int user_number = Convert.ToInt32(Console.ReadLine());
                // Iteration through list
                foreach (var num in numlist)
                {
                    // Prints results of each variable in list divided by user input
                    Console.WriteLine(num / user_number);
                }
            }
            // no exception errors given with dividing with negative number
            // catch triggered when user inputs 0
            catch (DivideByZeroException)
            { 
                Console.WriteLine("Please type in a number greater than 0"); 
            }
            // catch triggered when user inputs a string
            catch (FormatException)
            {
                Console.WriteLine("Please type in a number/just a number, not letters");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
