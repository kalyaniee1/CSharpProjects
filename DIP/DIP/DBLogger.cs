﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class DBLogger : ILogger
    {
        public void log(string error)
        {
            Console.WriteLine(error);
            Console.WriteLine("In DBLogger");
        }
    }
}
