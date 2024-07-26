using Akri.Mqtt;
using Akri.Mqtt.RPC;
using Akri.Mqtt.Session;
using AkriAspireDemo.AkriHelloWorld.dtmi_akri_samples_HelloWorld__1;

namespace AkriAspireDemo.AkriHelloWorld;

internal class HelloWorldService(MqttSessionClient mqttClient, ILogger<HelloWorldService> logger) : HelloWorld.Service(mqttClient)
{
    int commandsExecuted = 0;
    public override Task<ExtendedResponse<HelloCommandResponse>> HelloAsync(HelloCommandRequest request, CommandRequestMetadata requestMetadata, CancellationToken cancellationToken)
    {
        // await SendTelemetryAsync(new CommandsExecutedTelemetry { CommandsExecuted = commandsExecuted++ }, null!, MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce, null, cancellationToken);
        logger.LogInformation($"Received Hello request: {request.HelloRequest}");
        return Task.FromResult(new ExtendedResponse<HelloCommandResponse> 
                { 
                    Response = new HelloCommandResponse 
                    { 
                        HelloResponse = $"Hello, Hola {request.HelloRequest} at {DateTime.UtcNow.ToString("O")  }!" 
                    } 
            });
    }
}
