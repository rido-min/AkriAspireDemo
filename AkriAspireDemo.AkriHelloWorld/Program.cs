using AkriAspireDemo.AkriHelloWorld;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services
    .AddSingleton(MqttSessionClientFactoryProvider.MqttSessionClientFactory)
    .AddTransient<HelloWorldService>()
    .AddTransient<CounterService>()
    .AddHostedService<Worker>();

IHost host = builder.Build();
host.Run();
