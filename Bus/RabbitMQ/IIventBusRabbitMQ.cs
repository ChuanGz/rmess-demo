using System;
using Bus.Event.Core;
using Bus.CommandBus;

namespace Bus.RabbitMQ
{
	public interface IIventBusRabbitMq
	{
		void Publish(IntegrationEvent @event);

		void Subcrise<E, EH>()
			where E : IntegrationEvent
			where EH : IIntergrationEventandler<E>;
	}
}

