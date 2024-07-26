using AkriAspireDemo.AkriHelloWorld;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services
    .AddSingleton(MqttSessionClientFactoryProvider.MqttSessionClientFactory)
    .AddTransient<HelloWorldService>()
    .AddHostedService<Worker>();

IHost host = builder.Build();
host.Run();
