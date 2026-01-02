using System;

namespace Program
{
    public class Composition
    {
        public class Logger
        {
            public void Log(string message) 
            {
                Console.WriteLine(message);
            }
        }
        public class DbMigrator
        {
            private readonly Logger _logger;

            public DbMigrator(Logger logger)
            {
                _logger = logger;
            }
            public void Migrate()
            {
                _logger.Log("We are migrating blah blah blah...");
            }
        }
        public class Installer
        {
            private readonly Logger _logger;
            public Installer(Logger logger)
            {
                _logger = logger;
            }
            public void Install()
            {
                _logger.Log("We are installing the application.");
            }
        }
    }
}
