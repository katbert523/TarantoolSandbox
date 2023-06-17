namespace ApplicationSystem.Application
{
    /// <summary>
    /// Сервис для работы с блокировками абонентов.
    /// </summary>
    public interface IBlockInfoAbonentsService
    {
        /// <summary>
        /// Заблокирвоан ли абонент.
        /// </summary>
        Task<bool> IsBlockedAbonent(long msisdn);
    }
}
