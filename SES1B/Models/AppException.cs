using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace SES1B.Models

// Custom exception class for throwing application specific exceptions (e.g. for validation) 
// that can be caught and handled within the application
{
    [Serializable]
    internal class AppException : Exception
    {
        public AppException()
        {
        }

        public AppException(string message) : base(message)
        {
        }

        public AppException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AppException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public AppException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {

        }
    }
}