using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a new array, not giving it an index limit, this writing the strings to go into the array
            // and assigning them to a string type array under a certain name
            string[] Countries = new string[] { "Mexico", "Guatemala", "Belize", "El Salvador", "Honduras",
                "Nicaragua", "Costa Rica", "Panama" };

            // Asking user to choose a digit from a range
            Console.WriteLine("Please enter a number from 0 - 7");
            // Reading what digit the user inputted and converting it to an integer and assigning it to a int variable
            int i = Convert.ToInt32(Console.ReadLine());
            // If statement they checks if the int variable is greater than the number they were suppose to enter
            if (i > 7)
            { 
                // Executes this block of statement if test is true
                Console.WriteLine("The number has to be between 0 - 7, please try again");
                i = Convert.ToInt32(Console.ReadLine());
            }
            // If if not true, then console prints out the string at the number/index the user chose
            Console.WriteLine(Countries[i]);
            Console.ReadLine();

            // Creating a new array, not giving it an index limit, this writing the numbers to go into the array
            // and assigning them to an integer type array under a certain name
            int[] number = new int[] { 160170, 840, 26, 0, 138 };

            // Asking user to choose a digit from a range
            Console.WriteLine("Please enter a number from 0 - 4");
            // Reading what digit the user inputted and converting it to an integer and assigning it to a int variable
            int x = Convert.ToInt32(Console.ReadLine());
            // If statement they checks if the int variable is greater than the number they were suppose to enter
            if (x > 4)
            {
                // Executes this block of statement if test is true
                Console.WriteLine("The number has to be between 0 - 4, please try again");
                x = Convert.ToInt32(Console.ReadLine());
            }
            // If if not true, then console prints out the sinteger at the number/index the user chose
            Console.WriteLine(number[x]);
            Console.ReadLine();

            List<string> stringlist = new List<string>();
            // Adding a string to the list created
            stringlist.Add("Home");
            stringlist.Add("Page");
            stringlist.Add("does");
            stringlist.Add("not");
            stringlist.Add("exist");

            // Asking user to choose a digit from a range
            Console.WriteLine("Please enter a number from 0 - 4");
            // Reading what digit the user inputted and converting it to an integer and assigning it to a int variable
            int y = Convert.ToInt32(Console.ReadLine());
            // If statement they checks if the int variable is greater than the number they were suppose to enter
            if (y > 4)
            {
                // Executes this block of statement if test is true
                Console.WriteLine("The number has to be between 0 - 4, please try again");
                y = Convert.ToInt32(Console.ReadLine());
            }
            // If if not true, then console prints out the string at the number/index the user chose in the list
            Console.WriteLine(stringlist[y]);
            Console.ReadLine();
        }
    }

}


