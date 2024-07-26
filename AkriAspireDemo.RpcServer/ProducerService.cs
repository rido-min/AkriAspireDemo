using Akri.Mqtt;
using Akri.Mqtt.Session;
using MQTTnet.Protocol;

namespace AkriAspireDemo.RpcServer;

internal class ProducerService(MqttSessionClient mqttClient)
{
    public Task SendMessageAsync(string topic, string message, CancellationToken cancellationToken = default) 
        => mqttClient.PublishAsync(
            new MQTTnet.MqttApplicationMessageBuilder()
                .WithTopic(topic)
                .WithPayload(message)
                .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
                .Build(), cancellationToken);
}
