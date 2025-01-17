﻿using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Basic.RabbitMQ.Interfaces
{
    public interface IMessageConsumer
    {
        IModel Channel(string queueName, string routingKey);

        AsyncEventingBasicConsumer GetConsumer(IModel channel);
    }
}
