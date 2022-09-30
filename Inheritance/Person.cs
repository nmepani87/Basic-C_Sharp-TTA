using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        internal void SayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName +"]");
            return;

        }
    }
}
