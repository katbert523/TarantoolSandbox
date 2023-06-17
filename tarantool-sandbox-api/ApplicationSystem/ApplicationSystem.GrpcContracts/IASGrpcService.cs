using System.ServiceModel;

namespace ApplicationSystem.GrpcContracts;

/// <summary>
/// Сервис для работы с Application System.
/// </summary>
[ServiceContract]
public interface IASGrpcService
{
    /// <summary>
    /// Заблокирован ли абонент.
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    Task<IsBlockedAbonentResult> IsBlockedAbonent(IsBlockedAbonentArgs args);

    /// <summary>
    /// Создать запись cdr.
    /// </summary>
    [OperationContract]
    Task CreateCDR(CreateCDRArgs args);
}
