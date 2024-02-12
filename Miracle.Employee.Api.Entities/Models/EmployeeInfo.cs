using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miracle.Employee.Api.Entities.Models
{
    public class EmployeeInfo
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public Decimal Salary { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

    }
}
