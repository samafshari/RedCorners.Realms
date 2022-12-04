using System;
using System.Collections.Generic;
using System.Text;

namespace RedCorners
{
    public class RealmOperationException : AggregateException
    {
        public RealmOperationException(string message) : base(message) { }
        public RealmOperationException(string message, Exception innerException) : base(message, innerException) { }
    }
}
