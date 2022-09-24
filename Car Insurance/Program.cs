using System;
using System.Configuration;

namespace Car_Insurance
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Asking user a question in the console via WriteLine()
            Console.WriteLine("What is your age?");
            // Saving the answer the user inputs in the console to the string variable as named
            string AgeRequest = Console.ReadLine();
            // Converting the string variable to a byte variable and assigning it to a variable
            byte Age = Convert.ToByte(AgeRequest);

            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            // Saving the answer the user inputs in the console to the string variable as named
            string DUIRequest = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            // Saving the answer the user inputs in the console to the string variable as named
            string SpeedingRequest = Console.ReadLine();
            // Converting the string variable to a byte variable and assigning it to a variable
            byte Speeding = Convert.ToByte(SpeedingRequest);

            // Checking whether the answers the user inputted satisfy all 3 requirements by using AND operator and saving result and boolean variable
            bool approval = (Age > 15 && DUIRequest == "false" && Speeding <= 3);
            // Displaying the result, via the boolean variable, if the user qualifies for insurance
            Console.WriteLine("Qualified?\n" + approval);
        }
    }
}
