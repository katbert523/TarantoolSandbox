using ChargingSystem.Application;
using ChargingSystem.Grpc;
using ChargingSystem.Infrastructure;
using MediatR;
using ProtoBuf.Grpc.Server;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCodeFirstGrpc();
builder.Services.AddMediatR(typeof(ApplicationAss));

builder.Services.AddScoped<IBalanceStorageService, BalanceStorageService>();

var app = builder.Build();

app.MapGrpcService<CSGrpcService>();

app.Run();