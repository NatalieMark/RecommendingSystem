using System;
namespace RecommendingSystem02
{
    public class InsufficientValueException : Exception
    {
        public InsufficientValueException()
        {
        }

        public InsufficientValueException(string message) : base(message)
        {
        }

        public InsufficientValueException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
