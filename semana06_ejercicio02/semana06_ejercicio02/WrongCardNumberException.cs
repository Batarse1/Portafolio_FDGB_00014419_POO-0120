using System;

namespace semana06_ejercicio02
{
    public class WrongCardNumberException : Exception
    {
        public WrongCardNumberException(string message) : base(message)
        {
        }
    }
}