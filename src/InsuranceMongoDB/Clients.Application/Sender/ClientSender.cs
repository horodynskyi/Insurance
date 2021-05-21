using System;
using System.Text;
using System.Threading.Tasks;
using Clients.Domain.Models;
using Insurance.Queue.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace Clients.Application.Sender
{
    public class ClientSender :SenderConnection,IClientSender
    {
        public ClientSender(string hostname, string password, string queueName, string username) : base(hostname, password, queueName, username)
        {
        }
        public async Task Send(Client client)
        {
            if (ConnectionExists())
            {
                using (var channel = Connection.CreateModel())
                {
                    channel.QueueDeclare(queue: QueueName, durable: false, exclusive: false, autoDelete: false,
                        arguments: null);

                    var json = JsonConvert.SerializeObject(client);
                    var body = Encoding.UTF8.GetBytes(json);
                    channel.BasicPublish(exchange: "", routingKey: QueueName, basicProperties: null, body: body);
                }
            }
        }
    }
}

