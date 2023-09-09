using System;
using Bus.Event.Core;

namespace Bus.CommandBus
{
	public interface IIntergrationEventandler<E> where E: IntegrationEvent
	{
		Task Handle(E @event);
	}
}

