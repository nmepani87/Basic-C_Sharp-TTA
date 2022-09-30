using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Method_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classes classes = new Classes();
            Console.WriteLine("Please enter a number:");
            int intinput1 = Convert.ToInt32(Console.ReadLine());
            classes.Number(intinput1, out int total);
            Console.WriteLine(intinput1 + " divided by 2 equals " + total);
            Console.ReadLine();
            // Calling static class and function within it and writing function result to console
            Console.WriteLine(hiddenNumbers.numbers());
            Console.ReadLine();

        }
    }
}
