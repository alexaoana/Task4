﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base(message)
        { 

        }
    }
}
