/* This is an auto-generated file.  Do not modify. */

#nullable enable

namespace AkriAspireDemo.dtmi_com_example_Counter__1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using Akri.Mqtt;
    using Akri.Mqtt.RPC;
    using MQTTnet.Client;
    using AkriAspireDemo;

    public static partial class Counter
    {
        /// <summary>
        /// Specializes a <c>CommandExecutor</c> class for Command 'reset'.
        /// </summary>
        public class ResetCommandExecutor : CommandExecutor<EmptyJson, EmptyJson>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ResetCommandExecutor"/> class.
            /// </summary>
            internal ResetCommandExecutor(IMqttPubSubClient mqttClient)
                : base(mqttClient, "reset", new Utf8JsonSerializer())
            {
            }
        }
    }
}
