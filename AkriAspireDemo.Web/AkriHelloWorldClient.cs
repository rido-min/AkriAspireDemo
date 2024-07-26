using Akri.Mqtt.Session;
using Akri.Mqtt.Telemetry;
using AkriAspireDemo.AkriHelloWorld.dtmi_akri_samples_HelloWorld__1;

namespace AkriAspireDemo.Web
{
    public class AkriHelloWorldClient(MqttSessionClient mqttClient, ILogger<AkriHelloWorldClient> log) : HelloWorld.Client(mqttClient)
    {
        public override Task ReceiveTelemetry(string senderId, CommandsExecutedTelemetry telemetry, IncomingTelemetryMetadata metadata)
        {
            log.LogInformation($"Received telemetry from {senderId}: {telemetry.CommandsExecuted}");
            return Task.CompletedTask;
        }

        public async Task<string> HiRido()
        {
            var res = await HelloAsync("AkriAspireDemo.AkriHelloWorld", new HelloCommandRequest() { HelloRequest = "pepito" });
            return res.HelloResponse;
        }
    }
}
