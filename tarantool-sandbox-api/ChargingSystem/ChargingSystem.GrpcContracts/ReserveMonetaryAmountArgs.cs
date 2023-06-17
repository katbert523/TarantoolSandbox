using System.Runtime.Serialization;

namespace ChargingSystem.GrpcContracts
{
    /// <summary>
    /// Аргументы для резервации денежной суммы на балансе.
    /// </summary>
    [DataContract]
    public class ReserveMonetaryAmountArgs
    {
        /// <summary>
        /// Номер абонента.
        /// </summary>
        [DataMember(Order = 1)]
        public long Msisdn { get; init; }
    }
}