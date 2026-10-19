namespace CPTMS_serverV2.Modules.Core.Logger
{
    public static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine("["+DateTime.Now.ToString()+"]Log:" + message);
        }
        public static void LogWarning(string message)
        {
            Console.WriteLine("[" + DateTime.Now.ToString() + "]Warning:" + message);
        }
    }
}
