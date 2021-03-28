using System;

namespace BlazorMorse.Domain
{
    public class MorseException : Exception
    {
        public MorseException() : base() { }
        public MorseException(string message) : base(message) { }
    }
}