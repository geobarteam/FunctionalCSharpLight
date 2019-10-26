using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalCSharp
{
    public class Error
    {
        public Error(string message)
        {
            Message = message;
        }

        public Error(string message, Exception exception)
        {
            Message = message;
            Exception = exception;
        }

        public string Message { get; }
        public Exception Exception { get; }
    }
}
