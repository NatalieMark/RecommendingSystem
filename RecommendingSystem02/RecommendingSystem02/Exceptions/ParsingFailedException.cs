﻿using System;
namespace RecommendingSystem02
{
    public class ParsingFailedException : Exception
    {
        public ParsingFailedException()
        {
        }

        public ParsingFailedException(string message) : base(message)
        {
        }

        public ParsingFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
