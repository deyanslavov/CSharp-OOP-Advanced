namespace Logger.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        void Append(IError error);

        ErrorLevel Level { get; }
    }
}
