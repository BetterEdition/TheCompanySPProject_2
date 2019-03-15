using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompanySPProject.Model
{
    class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Minit { get; set; }

        public int SSN { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string Sex { get; set; }

        public Double Salary { get; set; }

        public int SuperSSN { get; set; }

        public int DepartmentNo { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ FirstName } { LastName } ({Address})";
            }
        }
    }
}
