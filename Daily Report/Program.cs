using System;


namespace Daily_Report
{
    internal class Program
    {
        static void Main()
        {
            // Prints two strings but breaking them up by escape sequence 
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            // Asking user a question
            Console.WriteLine("What is your name?");
            // Getting the user to input answer in console and assigning answer to string variable
            string name = Console.ReadLine();

            // Asking user a question
            Console.WriteLine("What course are you on?");
            // Getting the user to input answer in console and assigning answer to string variable
            string course = Console.ReadLine();

            // Asking user a question
            Console.WriteLine("What page number are you on?");
            // Getting the user to input answer in console and assigning answer to string variable
            string pagenumber = Console.ReadLine();
            // Converting the string variable to a 32 bit integer variable and assignment to a name
            int page = Convert.ToInt32(pagenumber);

            // Asking user a question and getting them to input answer in specific way
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False.\"");
            // Getting the user to input answer in console and assigning answer to string variable
            string anyhelp = Console.ReadLine();
            // Converting the string variable to a boolean variable and assignment to a name
            bool help = Convert.ToBoolean(anyhelp);

            // Asking user a question and asking them to go in depth
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            // Getting the user to input answer in console and assigning answer to string variable
            string experience = Console.ReadLine();

            // Asking user a question and asking them to go in depth
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            // Getting the user to input answer in console and assigning answer to string variable
            string feedback = Console.ReadLine();

            // Asking user a question
            Console.WriteLine("How many hours did you study today?");
            // Getting the user to input answer in console and assigning answer to string variable
            string studyhours = Console.ReadLine();
            // Converting the string variable to a 32 bit integer variable and assignment to a name
            int hours = Convert.ToInt32(studyhours);

            // Printing a string then getting user to hit enter to exit console
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
