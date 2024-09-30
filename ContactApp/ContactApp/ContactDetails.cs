using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class ContactDetails
    {
        static int _contactDetailsID = 0;
        string _contactType;
        bool _isActive;

        public int ContactTypeID { get; set; }
        public string ContactType { get; set; }

        public bool IsActive { get; set; }
        public ContactDetails(string contactType) {
            _contactDetailsID++;
            _contactType = contactType;
        }
    }
}
