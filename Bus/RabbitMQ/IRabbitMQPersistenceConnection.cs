using System;
using RabbitMQ.Client;

namespace Bus.RabbitMQ
{
	public interface IRabbitMQPersistenceConnection
    {
		bool IsConnected { get; }

		bool TryConnect();

		IModel CreateModel();

	}
}

