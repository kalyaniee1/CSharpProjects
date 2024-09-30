using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_SRP
{
    internal class Accounts
    {
        double[] incomeTaxRate = {0.1,0.2,0.3,0.4};
        double annumalIncomeTax;

        public double CheckIncomeTaxRate(Employee employee) {
            if (employee.Salary > 50000 && employee.Salary < 80000)
                return incomeTaxRate[0];
            else if (employee.Salary >=80000 && employee.Salary<120000 )
                return incomeTaxRate[1];
            else if(employee.Salary >= 120000 && employee.Salary<150000)
                return incomeTaxRate[2];
            else  
                return incomeTaxRate[3];
            

        }
        public double CalculateAnnualIncomeTax(Employee employee) { 
            return employee.Salary*CheckIncomeTaxRate(employee);
        }
    }
}
