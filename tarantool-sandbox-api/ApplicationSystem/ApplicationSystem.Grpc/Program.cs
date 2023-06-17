using ApplicationSystem.Application;
using ApplicationSystem.Grpc;
using ApplicationSystem.Infrastructure;
using MediatR;
using ProtoBuf.Grpc.Server;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCodeFirstGrpc();
builder.Services.AddMediatR(typeof(ApplicationAss));

builder.Services.AddScoped<IBlockInfoAbonentsService, BlockInfoAbonentsService>();
builder.Services.AddScoped<ICDRService, CDRService>();

var app = builder.Build();

app.MapGrpcService<ASGrpcService>();

app.Run();