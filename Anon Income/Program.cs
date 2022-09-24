using System;


namespace Anon_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prints an opening title in the console then asks user1 a question which is printed into the console via WriteLine()
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1 please enter your hourly rate:");
            // Assigning the answer, which is inputted through the Readline(), to a string variable 
            string person1hourly = Console.ReadLine();
            // Converting the string to a double value and assigning it double value name
            double p1hr = Convert.ToDouble(person1hourly);
            // Asking user1 a second question
            Console.WriteLine("Now enter the number of hours you work per week:");
            // Assigning the 2nd answer, which is inputted through the Readline(), to a string variable 
            string person1hours = Console.ReadLine();
            // Converting the string to a double value and assigning it double value name
            double p1hs = Convert.ToDouble(person1hours);
            // Multiplying values stored together and finally by 52 to work out annual salary, which is storage under a new double variable
            double totalp1 = p1hs * p1hr * 52;

            // Asking user2 the same first question as user1
            Console.WriteLine("Person 2 please enter your hourly rate:");
            string person2hourly = Console.ReadLine();
            // Converting the string to a double value and assigning it double value name
            double p2hr = Convert.ToDouble(person2hourly);
            // Asking user2 the same second question as user1
            Console.WriteLine("Now enter the number of hours you work per week:");
            // Assigning the 2nd answer, which is inputted through the Readline(), to a string variable 
            string person2hours = Console.ReadLine();
            // Converting the string to a double value and assigning it double value name
            double p2hs = Convert.ToDouble(person2hours);
            // Multiplying values stored together and finally by 52 to work out annual salary, which is storage under a new double variable
            double totalp2 = p2hs * p2hr * 52;

            // Printing into the console a string and the annual salary figure worked out from questions and answers above
            Console.WriteLine("Annual salary of Person 1: £" + totalp1);
            Console.WriteLine("Annual salary of Person 2: £" + totalp2);

            // Printing onto the console a question
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            // Making a comparison whether user1 salary is greater than user2 and storing answer as a boolean variable
            bool compare = totalp1 > totalp2;
            // Printing onto the console the true/false result from comparison
            Console.WriteLine(compare);
        }
    }
}
