using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1
            // Creating an array with a number of strings added to it and assigning it to a name
            string[] mountains = new string[] { "Mt. Everest", "Mt. Fuji", "Mt. Kilimanjaro",
                "Mt. Fitzroy", "Mt. Rainer" };
            // Looping through the array
            for (int i = 0; i < mountains.Length; i++)
            {
                // Ask user to input something into console
                Console.WriteLine("Please enter a mountain, it'll be added to an existing list");
                // Reading the input from the user and storing it as a string variable
                string new_entry = Console.ReadLine();
                // Appending that new variable to the array
                mountains = mountains.Append(new_entry).ToArray();
                // Looping through new array
                foreach (var item in mountains)
                {
                    // Printing into the console all the items in the array
                    Console.WriteLine(item);
                }
                // If statement to break to a position out of loop once check becomes true
                if (mountains.Length > 7)
                {
                    goto AfterLoop;
                }
            }
        // Assignment 2

        // AfterLoop:
        // Console.ReadLine();
        // INFINITE FOR LOOP AS ON PARAMETERS GIVEN SO NOTHING TO STOP IT
        // for (;;)
        // {
        // Console.WriteLine("MOUNTAINS! I can't imagine a more beautiful thing.");
        // }

        AfterLoop:
            Console.ReadLine();
            // Assignment 2 & 3 as J < 1 specified
            // Fix to infinite loop which has been commented out. Set interates to stop
            // until j is no longer less than 2
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine("MOUNTAINS! I can't imagine a more beautiful thing.");
            }

            // Assignment 3
            Console.ReadLine();
            // Itirations continue up to when k is equal to 2 
            for (int k = 0; k <= 2; k++)
            {
                Console.WriteLine(mountains[k] + " is one of the picturesque mountain in the world.");
            }
            Console.ReadLine();

            // Assignment 4
            //Creating a list that contains strings and adding the strings to the list
            List<string> volcanoes = new List<string> { "Kilauea", "Pacaya", "Volcán de Colima", "Mt. Yasur", "Erta Ale" };
           
            Console.WriteLine("There is a list of volcanoes already put together, " +
                "enter one volcano you think that might be in it");
            string vol_entry = Console.ReadLine();

            // Creating a loop that stops i after counter is more than 1
            for (int j = 0; j < 1; j++)
            {
                // when vol_entry (user input) matches string in list,
                // its index place is stored as integer variable
                int result = volcanoes.IndexOf(vol_entry);
                // If statement so if there is no match the user is made aware via string on console
                if (result == -1)
                    Console.WriteLine("Unfortunately that one is not on the list");
                // Other result, which contains index is written into the console
                else
                    Console.WriteLine(result);
            }
            Console.ReadLine();

            // Assignment 5
            //Creating a list that contains strings and adding the strings to the list
            List<string> lakes = new List<string> { "Como", "Victoria", "Crater", "Superior", "Como" };
            Console.WriteLine("There is a list of lakes already put together, " +
                "enter one lake you think that might be in it");
            string lake_entry = Console.ReadLine();

            // If statement, executes code within if list contains what the user inputted
            if (lakes.Contains(lake_entry))
            {   
                // Loop that goes for length of list
                for (int k = 0; k < lakes.Count; k++)
                    // If statement that checks if user entry equals to a item and position in list,
                    // then print thats position off
                    if (lakes[k] == lake_entry)
                        Console.WriteLine(k);
            }
            // If user input not in list else statement executed
            else
            {
                Console.WriteLine("That is not an option!");
            }
            Console.ReadLine();

            // Assignment 6
            //Creating a list that contains strings and adding the strings to the list
            List<string> seas = new List<string> { "Barents", "Kara", "Coral", "Okhotsk", "Laccadive", "Coral" };
            // creating variables that will store list strings
            var unique = new List<string>();
            var duplicate = new List<string>();
            
            // loop checks each item in item
            foreach (var l in seas)
            {   
                // If where if the string in the unique list the goes ahead and adds it in
                if (!unique.Contains(l))
                    unique.Add(l);
                // Else if entry already in unique list its added to different list instead
                else
                    duplicate.Add(l);
            }
            // loop through lists that have been seperated into 'unique/duplicate' and
            // prints the string from the list plus and string to go with it
            foreach (var m in unique)
            Console.WriteLine(m + " - this item is unique");
            foreach (var n in duplicate)    
            Console.WriteLine(n + " - this item is a duplicate");
            Console.ReadLine();
        }
    }
}
