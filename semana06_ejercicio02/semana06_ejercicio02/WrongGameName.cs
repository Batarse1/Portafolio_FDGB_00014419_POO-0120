using System;

namespace semana06_ejercicio02
{
    public class WrongGameName : Exception
    {
        public WrongGameName(string message) : base(message)
        {
        }
    }
}