/*
using System;
using RabbitMQ.Client;

namespace Clients.Application.Sender
{
    public class SenderConnection:ISenderConnection
    {
        protected readonly string Hostname;
        protected readonly string Password;
        protected readonly string QueueName;
        protected readonly string Username;
        protected IConnection Connection;

        public SenderConnection(string hostname, string password, string queueName, string username)
        {
            Hostname = hostname;
            Password = password;
            QueueName = queueName;
            Username = username;
            CreateConnection();
        }

        public void CreateConnection()
        {
            try
            {
                var factory = new ConnectionFactory
                {
                    HostName = Hostname,
                    UserName = Username,
                    Password = Password
                };
                Connection = factory.CreateConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not create connection: {ex.Message}");
            }
        }
        public bool ConnectionExists()
        {
            if (Connection != null)
            {
                return true;
            }

            CreateConnection();

            return Connection != null;
        }
    }
}
*/

