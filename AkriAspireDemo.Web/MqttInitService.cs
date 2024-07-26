
using Akri.Mqtt.Connection;
using Akri.Mqtt.Session;

internal class MqttInitService(MqttSessionClient mqttClient, IConfiguration config) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await mqttClient.ConnectAsync(MqttConnectionSettings.FromConnectionString(config.GetConnectionString("Default")!), stoppingToken);
    }
}