using System.Runtime.Serialization;

namespace ApplicationSystem.GrpcContracts
{
    /// <summary>
    /// Результат проверки блокировки абонента.
    /// </summary>
    [DataContract]
    public class IsBlockedAbonentResult
    {
        /// <summary>
        /// Заблокирован?
        /// </summary>
        [DataMember(Order = 1)]
        public bool Status { get; init; }
    }
}