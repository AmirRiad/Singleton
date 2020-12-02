namespace Singleton
{
    class Logger
    {
        private Logger simpleSingleton;
        private Logger()
        {
                
        }

        public Logger Instance {
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
