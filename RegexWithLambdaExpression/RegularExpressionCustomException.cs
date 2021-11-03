using System;

namespace RegexWithLambdaExpression
{
    public class RegularExpressionCustomException : Exception
    {
        public enum InvalidUserdetails
        {
            EMPTY_NAME,
            EMPTY_EMAIL,
            EMPTY_PHONE_NO,
            EMPTY_PASSWORD,
            INVALID_NAME,
            INVALID_EMAIL,
            INVALID_PHONE_NO,
            INVALID_PASSWORD
        }
        public readonly InvalidUserdetails error;
        /// <summary>
        /// creating a constructor and passing string message and exception type 
        /// </summary>
        /// <param name="error"></param>
        /// <param name="message"></param>
        public RegularExpressionCustomException(InvalidUserdetails error, string message) : base(message)
        {
            this.error = error;
        }
    }
}