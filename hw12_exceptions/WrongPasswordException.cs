using System;
using System.Collections.Generic;
using System.Text;

namespace hw12_exception
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base (message)
        { 
        }

        public WrongPasswordException() : base()
        {
        }
    }
}
