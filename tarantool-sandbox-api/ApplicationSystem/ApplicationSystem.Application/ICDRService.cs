namespace ApplicationSystem.Application
{
    /// <summary>
    /// Сервис для работы с CDR.
    /// </summary>
    public interface ICDRService
    {
        /// <summary>
        /// Создать CDR.
        /// </summary>        /// <returns></returns>
        Task CreateCDR(long senderMsisdn, long receiverMsisdn, DateTime eventDate);
    }
}
