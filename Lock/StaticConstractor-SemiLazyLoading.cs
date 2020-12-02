namespace Singleton.StaticConstractor
{
    public class  Logger : interfaceForLogger.ILogger
    {
        private static object obj = new object();

        private static Logger LoggerByStaticConstractor;
        private Logger()
        {

        }
        static  Logger()
        {
            LoggerByStaticConstractor = new Logger();
        }
        public static  int Id
        {
            get
            {

                return 1;
            }
        }
        public static Logger Instance
        {
            get
            {

                return LoggerByStaticConstractor;
            }
        }

        public void LogError(string msg)
        {
            System.Console.WriteLine(msg);
        }

    }
}
