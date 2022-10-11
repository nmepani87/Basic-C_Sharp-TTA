using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace codefirstStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Please enter the student's first name.");
                var fname = Console.ReadLine();
                Console.WriteLine("Now enter their last name.");
                var lname = Console.ReadLine();
                Console.WriteLine("And finally please enter their age.");
                var age = Convert.ToInt32(Console.ReadLine());

                var student = new Student { FirstName = fname, LastName = lname, Age = age };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from x in db.Students
                            orderby x.LastName
                            select x;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
