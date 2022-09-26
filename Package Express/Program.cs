using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Printing a welcoming and statement, following by a question for the user (different line via escape sequence) in the console via WriteLine()
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter the number of kgs the package weights.");
            // Converting the input from the user via Readline() and assigning it to a int variable with a name
            int weight = Convert.ToInt32(Console.ReadLine());
            // If statement that checks that if variable is greater than a number to process with block of code for it
            if (weight > 50)
            {   
                // Letting user know that variable hasn't passed test and proceeds to end console program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
            }
            // Else statement that kicks in if the if statement check was false and to process this block of code instead
            else
            {
                // Printing the user a question via WriteLine()
                Console.WriteLine("Please enter the package width:");
                // Converting the input from the user via Readline() and assigning it to a int variable with a name
                int width = Convert.ToInt32(Console.ReadLine());
                // Printing the user a question via WriteLine()
                Console.WriteLine("Please enter the package height:");
                // Converting the input from the user via Readline() and assigning it to a int variable with a name
                int height = Convert.ToInt32(Console.ReadLine());
                // Printing the user a question via WriteLine()
                Console.WriteLine("Please enter the package length:");
                // Converting the input from the user via Readline() and assigning it to a int variable with a name
                int length = Convert.ToInt32(Console.ReadLine());
                // If statement that checks that if 3 of the stored variables, added together first, is greater than a number to process with block of code for it
                if ((width + height + length) > 50)
                {
                    // Printing the user a statement via WriteLine()
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                // Else statement to kick in if if check was false
                else 
                {
                    // Multiplying the 4 saves int variables first together, then dividing that total and saving the final number to an int variable
                    int total = (width * height * length * weight)/100;
                    // Printing the user a statement that contains the int variable(which worked out the estimated cost) via WriteLine()
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total + "\nThank you!");
                    Console.Read();
                }


            }
        }
    }
}
