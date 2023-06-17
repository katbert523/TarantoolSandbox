namespace ChargingSystem.Application;

/// <summary>
/// Сервис для работы с Balance Storage
/// </summary>
public interface IBalanceStorageService
{
    /// <summary>
    /// Зарезервировать денежную сумму на балансе абонента.
    /// </summary>
    /// <param name="msisdn">Msisdn абонента.</param>
    /// <returns>Удалость ли провести резервацию.</returns>
    Task<bool> ReserveMonetaryAmount(long msisdn);
}
