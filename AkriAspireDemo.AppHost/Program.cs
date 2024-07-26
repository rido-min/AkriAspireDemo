var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.AkriAspireDemo_ApiService>("apiservice");
var mqttService = builder.AddProject<Projects.AkriAspireDemo_RpcServer>("mqttservice");

builder.AddProject<Projects.AkriAspireDemo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WithReference(apiService)
    .WithReference(mqttService);

builder.Build().Run();
