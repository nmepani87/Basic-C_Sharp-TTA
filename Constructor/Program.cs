using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Chaining obj = new Chaining();
        }

        public class Chaining
        {
            // Giving method a int value to to giving to next method
            public Chaining() : this((int)3.14159)
            {
                string Pi = "3.14159";
                Console.WriteLine("The value of Pi is " + Pi);
            }
            // Taking in default value giving from previous method
            public Chaining(int PiValue)
            {
                // Defining integer value as a var variable
                var Pi =  PiValue;
                // Defining a constant integer value
                const int Radius = 5;
                // New int variable that holds value of calculations done using previous variables
                int area = PiValue * Radius * Radius;
                Console.WriteLine("The area for a circle is worked out as " + Pi + " * " + Radius + "², " +
                    "which results in " + area + ". But this is incorrect as Pi has been rounded down!");
                Console.ReadLine();
            }
        }
    }
}
