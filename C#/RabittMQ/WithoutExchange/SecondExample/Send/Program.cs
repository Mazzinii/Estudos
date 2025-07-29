using RabbitMQ.Client;
using System.Text;

// Connection
var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = await factory.CreateConnectionAsync();
using var channel = await connection.CreateChannelAsync();

await channel.QueueDeclareAsync(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);
await channel.QueueDeclareAsync(queue: "task_queue", durable: true, exclusive: false, autoDelete: false, arguments: null);


Console.WriteLine("Send your message (Send exit to exit):");
Console.WriteLine();

while (true)
{
    string message = Console.ReadLine();

    if (message == "exit") break;

    var body = Encoding.UTF8.GetBytes(message!);

    var properties = new BasicProperties
    {
        Persistent = true,
    };

    await channel.BasicPublishAsync(exchange: string.Empty, routingKey: "hello", body: body);
}


Console.WriteLine(" Press [enter] to exit.");
Console.WriteLine();


