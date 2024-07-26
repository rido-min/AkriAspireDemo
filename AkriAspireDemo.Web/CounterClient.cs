using Akri.Mqtt.Session;

namespace AkriAspireDemo.Web;

public class CounterClient(MqttSessionClient mqttClient) : dtmi_com_example_Counter__1.Counter.Client(mqttClient)
{
}
