using System;
using System.Linq;
using System.Security.Cryptography;

[Flags] enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

namespace Parsing_enums
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is the current day of the week");
                string userday = Console.ReadLine();
                // Getting the curent date and time and assigning to a name
                DateTime now = DateTime.Now;
                // Converting to string the current day from the date/time stored within now variable
                string currentday = Convert.ToString(now.DayOfWeek);

                Days daysValue = (Days)Enum.Parse(typeof(Days), userday);
                // If to check user input matchs to a current day of week retrieved and
                // also if user input is inside enums via parsing of info assigned to above variable
                if (userday == currentday && userday == daysValue.ToString())
                {

                    Console.WriteLine("You entered the correct day, it is " + currentday + " today!");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("You may have been mistaken, it is in fact " + currentday + " today!");
                    userday = Console.ReadLine();
                }

            }
            // Catch, if user inputs something other than a day
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}
