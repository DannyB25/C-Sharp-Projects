using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception //inherits from Exception
    {
        public FraudException() //constructor
            : base() { } //inherits from base exception
        public FraudException(string message) //overloaded constructor
            : base(message) { } //inherits from base exception
    }
}
