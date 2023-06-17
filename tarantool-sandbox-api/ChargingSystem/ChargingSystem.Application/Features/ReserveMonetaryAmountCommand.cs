using MediatR;

namespace ChargingSystem.Application.Features
{
    /// <summary>
    /// Команда на резервацию.
    /// </summary>
    public class ReserveMonetaryAmountCommand : IRequest<bool>
    {
        /// <summary>
        /// Msisdn абонента.
        /// </summary>
        public long Msisdn { get; init; }

        public ReserveMonetaryAmountCommand(long msisdn)
        {
            Msisdn = msisdn;
        }
    }
}
