using System;
using Entities;

namespace Exceptions
{
    public class BusinessException : Exception
    {
        public int ExceptionID;

        public BusinessException()
        {
        }

        public BusinessException(int exceptionId)
        {
            ExceptionID = exceptionId;
        }

        public BusinessException(int exceptionId, Exception innerException)
        {
            ExceptionID = exceptionId;
        }

        public ApplicationMessage AppMessage { get; set; }
    }
}