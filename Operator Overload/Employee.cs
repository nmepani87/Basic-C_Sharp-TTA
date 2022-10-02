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

        public static bool operator ==(Employee EmployeeA, Employee EmployeeB)
        {
            if (EmployeeA.ID.Equals(EmployeeB.ID))
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee EmployeeA, Employee EmployeeB)
        {
            if (EmployeeA.ID.Equals(EmployeeB.ID))
                return false;
            else
                return true;
        }
    }
}
