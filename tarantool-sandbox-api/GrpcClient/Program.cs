using ApplicationSystem.GrpcContracts;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:5052");
        var client = channel.CreateGrpcService<IASGrpcService>();

        var grpcArgs = new CreateCDRArgs { SenderMsisdn = 89998887766, ReceiverMsisdn = 911 };

        await client.CreateCDR(grpcArgs);


        //var grpcArgs = new IsBlockedAbonentArgs { Msisdn = 89998887755 };

        //var res = await client.IsBlockedAbonent(grpcArgs);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}