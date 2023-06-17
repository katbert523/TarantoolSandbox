using ChargingSystem.Application.Features;
using ChargingSystem.GrpcContracts;
using MediatR;

namespace ChargingSystem.Grpc
{
    /// <inheritdoc cref="ICSGrpcService"/>
    public class CSGrpcService : ICSGrpcService
    {
        private readonly IMediator _mediator;

        public CSGrpcService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ReserveMonetaryAmountResult> ReserveMonetaryAmount(ReserveMonetaryAmountArgs args)
        {
            var query = new ReserveMonetaryAmountCommand(args.Msisdn);

            var isSuccessReservation = await _mediator.Send(query);

            return new ReserveMonetaryAmountResult { IsSuccessReservation = isSuccessReservation };
        }
    }
}
