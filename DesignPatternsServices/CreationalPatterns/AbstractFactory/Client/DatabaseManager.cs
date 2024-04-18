using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.AbstractFactory.Client
{
    public class DatabaseManager
    {
        private readonly ICommand _command;
        private readonly IConnection _connection;

        public DatabaseManager(ICommand command, IConnection connection)
        {
            _command = command;
            _connection = connection;
        }

        public string PerformDatabaseOperations(string query)
        {
            var connection = _connection.OpenConnection();
            var command = _command.Execute(query);

            return $"{connection} \n{command}";
        }
    }
}
