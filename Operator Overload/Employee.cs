using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    internal class Employee
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int ID { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        // Operater overload in == 
        public static bool operator ==(Employee EmployeeA, Employee EmployeeB)
        {
            // Checking if the two values within ID are the same and returning true/false based upon that
            if (EmployeeA.ID.Equals(EmployeeB.ID))
                return true;
            else
                return false;
        }

        // Opposite to above bool check to satisfy == check done in pairs (with !=)
        public static bool operator !=(Employee EmployeeA, Employee EmployeeB)
        {
            if (EmployeeA.ID.Equals(EmployeeB.ID))
                return false;
            else
                return true;
        }
    }
}
