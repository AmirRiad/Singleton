namespace Singleton.Lock
{
    public class Logger : interfaceForLogger.ILogger
    {
        private static object obj = new object();

        private static Logger LoggerByLock;
        private Logger()
        {
                
        }

        //public static Logger Instance {
        //    get {
        //        lock(obj)
        //        {
        //            if (LoggerByLock == null)
        //            {
        //                LoggerByLock = new Logger();
        //            }
        //            return LoggerByLock;
        //        }

        //    }
        //}

        public static Logger Instance
        {
            get
            {

                if (LoggerByLock == null)
                {
                    lock (obj)
                    {
                        LoggerByLock = new Logger();
                    }
                }
                return LoggerByLock;
            }
        }

        public void LogError(string msg)
        {
            System.Console.WriteLine(msg);
        }

    }
}
