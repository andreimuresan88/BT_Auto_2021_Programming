﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NUnit_Auto_2022.Utilities
{
    [Serializable]
    internal class BrowerTypeException : Exception
    {
        public BrowerTypeException()
        {
        }

        public BrowerTypeException(string message) : base("Unsupported browser type " + message)
        {

        }

        public BrowerTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BrowerTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
