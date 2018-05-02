namespace Logger.Contracts
{
    using System.Collections.Generic;

    public interface ILogger
    {
        void Log(IError error);

        IReadOnlyCollection<IAppender> Appenders { get; }
    }
}
