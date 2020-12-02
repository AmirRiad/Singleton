namespace Singleton.SimpleSingleton
{
    public class Logger
    {
        private static Logger simpleSingleton;
        private Logger()
        {
                
        }

        public static Logger Instance {
            get {
                if (simpleSingleton == null)
                {
                    simpleSingleton = new Logger();
                }
                return simpleSingleton;
            }
        }

        public void LogError(string msg)
        {
            System.Console.WriteLine(msg);
        }

    }
}
