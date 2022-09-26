using System;


namespace While_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printing the user a question in the console via WriteLine()
            Console.WriteLine("What is your favourite Italian car manufacturer?");
            // Getting the user input read, via ReadLine(), and assigning it to a string variable 
            string car = Console.ReadLine();
            // Creating a Boolean test which check if the user input storaged in the above variable is equal to a specific string
            bool correct = car == "Lamborghini";

            // while statement that gets processed whilst the boolean variable is not correct
            while (!correct)
            {
                // Getting the car variable evaulated
                switch (car)
                {
                    // If user input is the string written in this case then this block of code is executed,
                    // with the boolean remaining false the user is asked for another input
                    case "Ferrari":
                        Console.WriteLine("You picked Ferrari, they're ok, but try pick a better one now");
                        car = Console.ReadLine();
                        break;
                    case "Maserati":
                        Console.WriteLine("You picked Maserati, they're ok, but try pick a better one now");
                        car = Console.ReadLine();
                        break;
                    case "Alfa_Romeo":
                        Console.WriteLine("You picked Alfa Romeo, they're ok, but try pick a better one now");
                        car = Console.ReadLine();
                        break;
                    case "Fiat":
                        Console.WriteLine("You picked Fiat, they're ok, but try pick a better one now");
                        car = Console.ReadLine();
                        break;
                    // If user input is the string written in this case then this block of code is executed,
                    // here the boolean test is changed to true and the switch check is stopped
                    case "Lamborghini":
                        correct = true;
                        break;
                    // Default block executed if user input doesn't match any strings that have cases written for them
                    default:
                        Console.WriteLine("You need to pick an Italian manufacturer!");
                        Console.WriteLine("Please enter another manufacturer");
                        car = Console.ReadLine();
                        break;
                }
            }
            // Printing a statement and question, split via escape sequence, in the console
            Console.WriteLine("Your favourite car is Lamborghini, a very good and correct choice!\nNow guess our favourite Lamborghini model");
            // Getting the user input read, via ReadLine(), and assigning it to a string variable 
            string model = Console.ReadLine();
            // Creating a Boolean test which check if the user input storaged in the above variable is equal to a specific string
            bool rightmodel = model == "Murcielago";

            // do/while loop to be executed
            do
            {
                // Getting the model variable evaulated
                switch (model)
                    {
                    case "Diablo":
                        Console.WriteLine("You picked the Diablo, nice choice but not the correct one. Pick another one.");
                        model = Console.ReadLine();
                        break;
                    case "Countach":
                        Console.WriteLine("You picked the Countach, nice choice but not the correct one. Pick another one.");
                        model = Console.ReadLine();
                        break;
                    case "Aventador":
                        Console.WriteLine("You picked the Aventador, nice choice but not the correct one. Pick another one.");
                        model = Console.ReadLine();
                        break;
                    case "Miura":
                        Console.WriteLine("You picked the Miura, nice choice but not the correct one. Pick another one.");
                        model = Console.ReadLine();
                        break;
                    case "Urus":
                        Console.WriteLine("You picked the Urus, nice choice but not the correct one. Pick another one.");
                        model = Console.ReadLine();
                        break;
                    case "Reventon":
                        Console.WriteLine("You picked the Reventon, nice choice but not the correct one. Pick another one.");
                        model = Console.ReadLine();
                        break;
                    case "Murcielago":
                        Console.WriteLine("Correct! The sound of this V12 made this model our favourite.");
                        rightmodel = true;
                        break;
                    }
                }
            // Condition to carry on executing blocks whilst rightmodel bolean is still not true
            while (!rightmodel);
        }

    }
}