﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class UserDoesNotExistsException:Exception
    {
        public UserDoesNotExistsException(string message):base(message) { }
    }
}
