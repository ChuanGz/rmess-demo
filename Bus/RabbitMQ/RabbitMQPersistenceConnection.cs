using System;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;

namespace Bus.RabbitMQ
{
    public class RabbitMQPersistenceConnection : IRabbitMQPersistenceConnection
    {
        private readonly IConnectionFactory connectionFactory;
        private readonly ILogger<RabbitMQPersistenceConnection> logger;
        private readonly int retryCount;
        private IConnection connection;
        private bool disposed;
        public bool IsConnected => throw new NotImplementedException();

        public RabbitMQPersistenceConnection(IConnectionFactory connectionFactory,
            ILogger<RabbitMQPersistenceConnection> logger,
            int retryCount)
        {
            this.connectionFactory = connectionFactory;
            this.logger = logger;
            this.retryCount = retryCount;
        }

        public IModel CreateModel()
        {
            throw new NotImplementedException();
        }

        public bool TryConnect()
        {
            throw new NotImplementedException();
        }
    }
}

