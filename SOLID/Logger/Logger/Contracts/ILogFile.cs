namespace Logger.Contracts
{
    public interface ILogFile
    {
        int Size { get; }

        string Path { get; }


        void WriteToFile(string errorLog);
    }
}
