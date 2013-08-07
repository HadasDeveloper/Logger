using System.Diagnostics;


namespace Logger
{
    public class EventLogWriter
    {
        private string eventLogName;

        public EventLogWriter()
        {
            eventLogName = "userEventLog";
        }

        public EventLogWriter(string logName)
        {
            eventLogName = logName;
        }

        public void WriteToEventLog(string message)
        {
            if (!EventLog.SourceExists(eventLogName))
                EventLog.CreateEventSource(eventLogName, "Application");

            EventLog.WriteEntry(eventLogName, message);
        }

        public void WriteErrorToEventLog(string message)
        {
            if (!EventLog.SourceExists(eventLogName))
                EventLog.CreateEventSource(eventLogName, "Application");

            EventLog.WriteEntry(eventLogName, message, EventLogEntryType.Error);
        }
    }
}
