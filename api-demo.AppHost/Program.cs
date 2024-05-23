var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Api_Demo>("api-demo");

builder.Build().Run();
