﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieStore movieStore = new MovieStore();
            
            movieStore.showMenu();
        }
    }
}
