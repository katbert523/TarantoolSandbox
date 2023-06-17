using System.Runtime.Serialization;

namespace ApplicationSystem.GrpcContracts
{
    /// <summary>
    /// Аргументы для проверки блокировки на абоненте.
    /// </summary>
    [DataContract]
    public class CreateCDRArgs
    {
        /// <summary>
        /// Номер вызывающего абонента.
        /// </summary>
        [DataMember(Order = 1)]
        public long SenderMsisdn { get; init; }

        /// <summary>
        /// Номер абонента, принимающего звонок.
        /// </summary>
        [DataMember(Order = 2)]
        public long ReceiverMsisdn { get; init; }
    }
}