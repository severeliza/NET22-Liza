using System;
using System.Collections.Generic;
using System.Text;

namespace hw12_exception
{
    public class WrongLoginException : Exception
    {
        public WrongLoginException(string message) : base(message)
        {
        }

        public WrongLoginException() : base()
        {
        }
    }
}
