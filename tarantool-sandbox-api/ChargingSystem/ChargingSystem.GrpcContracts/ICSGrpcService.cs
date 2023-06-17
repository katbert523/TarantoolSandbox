using System.ServiceModel;

namespace ChargingSystem.GrpcContracts;

/// <summary>
/// Сервис для работы с Charging System.
/// </summary>
[ServiceContract]
public interface ICSGrpcService
{
    /// <summary>
    /// Зарезервировать денежную сумму на балансе.
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    Task<ReserveMonetaryAmountResult> ReserveMonetaryAmount(ReserveMonetaryAmountArgs args);
}
