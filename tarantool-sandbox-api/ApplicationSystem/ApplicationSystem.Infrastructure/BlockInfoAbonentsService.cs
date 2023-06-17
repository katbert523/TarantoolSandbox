using ApplicationSystem.Application;
using ProGaudi.Tarantool.Client;
using ProGaudi.Tarantool.Client.Model;

namespace ApplicationSystem.Infrastructure;

/// <inheritdoc cref="IBlockInfoAbonentsService"/>
public class BlockInfoAbonentsService : IBlockInfoAbonentsService
{
    private const string BlockedAbonentsSpace = "blocked_abonents";

    public async Task<bool> IsBlockedAbonent(long msisdn)
    {
        var space = await GetBlockedAbonentsSpace();

        var secondaryIndex = await space.GetIndex("secondary");

        var abonentRecord = await secondaryIndex
            .Select<TarantoolTuple<long>, TarantoolTuple<string, long, bool>>(TarantoolTuple.Create(msisdn));

        var currentAbonent = abonentRecord.Data.Select(x => x).FirstOrDefault();

        if (currentAbonent == null) throw new Exception($"Абонент с msisdn: {msisdn} не найден!");

        return currentAbonent.Item3;
    }

    private async Task<ISpace> GetBlockedAbonentsSpace()
    {
        var box = await Box.Connect("127.0.0.1:3301");  //в конфиг

        var schema = box.GetSchema();

        return await schema.GetSpace(BlockedAbonentsSpace);
    }
}
