﻿using System;

namespace UserMicroservice.Exceptions
{
    [Serializable]
    public class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException()
            : base("The password is incorrect.")
        {
        }
    }
}