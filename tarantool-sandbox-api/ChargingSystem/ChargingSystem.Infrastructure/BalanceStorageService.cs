using ChargingSystem.Application;
using ProGaudi.Tarantool.Client;
using ProGaudi.Tarantool.Client.Model;
using ProGaudi.Tarantool.Client.Model.UpdateOperations;

namespace ChargingSystem.Infrastructure;

/// <inheritdoc cref="IBalanceStorageService"/>
public class BalanceStorageService : IBalanceStorageService
{
    private const int ReservationAmount = 100;
    private const string BalanceStorageSpace = "balance_storage";
    private const int BalanceAmountPosition = 2;

    public async Task<bool> ReserveMonetaryAmount(long msisdn)
    {
        var space = await GetBalanceStorageSpace();

        var msisdnIndex = await space.GetIndex("secondary");

        var balanceRecord = await msisdnIndex
            .Select<TarantoolTuple<long>, TarantoolTuple<string, long, int>>(TarantoolTuple.Create(msisdn));

        var currentBalance = balanceRecord.Data.Select(x => x).FirstOrDefault();

        var residualBalance = currentBalance.Item3 - ReservationAmount;

        if (residualBalance <= 0) return false;

        await space.Update<TarantoolTuple<string>, TarantoolTuple<string, long, int>>
            (TarantoolTuple.Create(currentBalance.Item1),
            new UpdateOperation[] { UpdateOperation.CreateAssign<long>(BalanceAmountPosition, residualBalance) });

        return true;
    }

    private async Task<ISpace> GetBalanceStorageSpace()
    {
        var box = await Box.Connect("127.0.0.1:3301");  //в конфиг

        var schema = box.GetSchema();

        return await schema.GetSpace(BalanceStorageSpace);
    }
}
