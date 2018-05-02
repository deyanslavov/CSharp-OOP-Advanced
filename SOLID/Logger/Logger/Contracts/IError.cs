namespace Logger.Contracts
{
    using System;

    public interface IError
    {
        DateTime DateTime { get; }

        string Message { get; }

        ErrorLevel ErrorLevel { get; }
    }
}