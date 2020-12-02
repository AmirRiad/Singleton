namespace Singleton.StaticConstractorFulllazyLoading
{
    public class  Logger : interfaceForLogger.ILogger
    {
        private class InnerLogger {
            public static Logger LoggerByStaticConstractor;

            static InnerLogger()
            {
                LoggerByStaticConstractor = new Logger();
            }
        }
    
        public static Logger Instance
        {
            get
            {

                return InnerLogger.LoggerByStaticConstractor;
            }
        }

        public void LogError(string msg)
        {
            System.Console.WriteLine(msg);
        }

    }
}
