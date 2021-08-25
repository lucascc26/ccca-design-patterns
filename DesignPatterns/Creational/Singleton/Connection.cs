using System;

namespace DesignPatterns.Creational.Singleton
{
    public class Connection
    {
        private static Connection _connection;

        public Guid Id { get; private set; }

        private Connection()
        {
            Id = Guid.NewGuid();
        }

        public static Connection Instance
        {
            get
            {
                if (_connection == null)
                    _connection = new Connection();

                return _connection;
            }
        }
    }
}
