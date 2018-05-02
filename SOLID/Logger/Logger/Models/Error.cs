namespace Logger.Models
{
    using Contracts;
    using System;

    public class Error : IError
    {
        public Error(DateTime dateTime, ErrorLevel level, string message)
        {
            this.DateTime = dateTime;
            this.ErrorLevel = level;
            this.Message = message;
        }

        public DateTime DateTime { get; }

        public string Message { get; }

        public ErrorLevel ErrorLevel { get; }
    }
}
