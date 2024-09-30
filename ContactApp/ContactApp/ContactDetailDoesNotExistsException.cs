using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class ContactDetailDoesNotExistsException : Exception
    {
        public ContactDetailDoesNotExistsException(string message) : base(message) { }
    }
}
