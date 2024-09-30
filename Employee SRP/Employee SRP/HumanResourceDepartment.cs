using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_SRP
{
    internal class HumanResourceDepartment
    {
        
        public HumanResourceDepartment() { 
        
        }

        public bool PromotionDue(Employee employee) {
            //Console.WriteLine(employee.DateOfJoining.Year);
            if(DateTime.Now.Year-employee.DateOfJoining.Year>2)
                return true;
            else return false;
        }
    }
}
