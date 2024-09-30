using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class Contact
    {
        static int _contactID=0; 
        string _firstName,_lastName;
        bool _isActive = true;
        List<ContactDetails> contact_Details=new List<ContactDetails> ();

        public static int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public Contact(string firstName, string lastName) {
            _contactID++;
            _firstName = firstName;
            _lastName = lastName;
        }

    }
}
