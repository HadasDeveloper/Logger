namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLogWriter ev = new EventLogWriter("testEventLog");

            ev.WriteToEventLog("test");

        }
    }
}
