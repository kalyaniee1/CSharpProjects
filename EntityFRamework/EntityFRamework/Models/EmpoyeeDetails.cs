using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFRamework.Models
{
    internal class EmpoyeeDetails
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
