/* This is an auto-generated file.  Do not modify. */

#nullable enable

namespace AkriAspireDemo.dtmi_com_example_Counter__1
{
    using System;
    using System.Collections.Generic;
    using Akri.Mqtt;
    using Akri.Mqtt.RPC;
    using MQTTnet.Client;
    using AkriAspireDemo;

    public static partial class Counter
    {
        /// <summary>
        /// Specializes the <c>CommandInvoker</c> class for Command 'increment'.
        /// </summary>
        public class IncrementCommandInvoker : CommandInvoker<EmptyJson, IncrementCommandResponse>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="IncrementCommandInvoker"/> class.
            /// </summary>
            internal IncrementCommandInvoker(IMqttPubSubClient mqttClient)
                : base(mqttClient, "increment", new Utf8JsonSerializer())
            {
            }
        }
    }
}
