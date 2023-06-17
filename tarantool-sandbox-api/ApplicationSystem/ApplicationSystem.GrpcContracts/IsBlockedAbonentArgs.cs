using System.Runtime.Serialization;

namespace ApplicationSystem.GrpcContracts
{
    /// <summary>
    /// Аргументы для проверки блокировки на абоненте.
    /// </summary>
    [DataContract]
    public class IsBlockedAbonentArgs
    {
        /// <summary>
        /// Номер абонента.
        /// </summary>
        [DataMember(Order = 1)]
        public long Msisdn { get; init; }
    }
}