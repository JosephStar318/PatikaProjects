using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();
            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();


        }
    }
    
}
