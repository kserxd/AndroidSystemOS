using System;
using System.Collections.Generic;
using System.Text;

namespace AndroidSystemOS.Commands
{
    class Error
    {
        string[] errors = new string[2] {"Invalid command", "Not much data"};
        public Error(int errorCode)
        {
            Console.WriteLine(errors[errorCode]);
        }
    }
}
