namespace FileDb.Brokers.Logging
{
    internal interface ILoggingBroker
    {
        void LogInforamation(string message);
        void LogError(string userMessage);
        void LogSuccessUser(string message);
    }
}
