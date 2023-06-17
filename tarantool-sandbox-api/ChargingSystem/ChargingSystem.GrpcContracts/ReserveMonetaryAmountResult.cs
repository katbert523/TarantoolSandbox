using System.Runtime.Serialization;

namespace ChargingSystem.GrpcContracts
{
    /// <summary>
    /// Результат резервации.
    /// </summary>
    [DataContract]
    public class ReserveMonetaryAmountResult
    {
        /// <summary>
        /// Удачно ли прошла резервация.
        /// </summary>
        [DataMember(Order = 1)]
        public bool IsSuccessReservation { get; init; }
    }
}