using Singleton.Lazy;
using System;

namespace Singleton
{

    class logger
    {
        private static logger _logger { get; set; }
        private logger()
        {

        }

        public static logger Instance { get {

                if (_logger == null)
                {
                    _logger = new logger();
                }

                return _logger;
                
            } }
        public void logInfo(string message)
        {
            Console.WriteLine("log "+ message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            logger log1 = logger.Instance;
            logger log2 = logger.Instance;
            var x= object.ReferenceEquals(log1, log2);
            Console.WriteLine("Is Equal "+x.ToString());
            Console.ReadLine();

    }
}
}
