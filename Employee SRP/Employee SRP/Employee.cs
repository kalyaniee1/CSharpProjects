using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_SRP
{
    internal class Employee
    {
        string _ID, _name, _city;
        DateTime _dateOFJoining;
        double _salary;

        public Employee(string ID, string name, string city, DateTime dateOfJoining, double salary) {
            _ID = ID;
            _name = name;
            _city = city;
            _dateOFJoining= dateOfJoining;
            _salary = salary;
        }

        public DateTime DateOfJoining {
            get { return _dateOFJoining; }
        }

        public double Salary{
            get { return _salary; }
}
    }   
}
