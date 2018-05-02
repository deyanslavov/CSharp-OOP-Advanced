using System;
using System.Collections.Generic;
using System.Text;

public class EventLogger : Logger
{
    public override void Handle(LogType logType, string message)
    {
        switch (logType)
        {
            case LogType.TARGET:
                Console.WriteLine(logType.ToString() + ": " + message);
                break;
            case LogType.ERROR:
                Console.WriteLine(logType.ToString() + ": " + message);
                break;
            case LogType.EVENT:
                Console.WriteLine(logType.ToString() + ": " + message);
                break;
        }
    }
}
