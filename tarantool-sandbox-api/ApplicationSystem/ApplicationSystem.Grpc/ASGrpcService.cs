using ApplicationSystem.Application.Features;
using ApplicationSystem.GrpcContracts;
using MediatR;

namespace ApplicationSystem.Grpc
{
    /// <inheritdoc cref="IASGrpcService"/>
    public class ASGrpcService : IASGrpcService
    {
        private readonly IMediator _mediator;

        public ASGrpcService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task CreateCDR(CreateCDRArgs args)
        {
            var command = new CreateCDRCommand(args.SenderMsisdn, args.ReceiverMsisdn, DateTime.Now);

            await _mediator.Send(command);
        }

        public async Task<IsBlockedAbonentResult> IsBlockedAbonent(IsBlockedAbonentArgs args)
        {
            var query = new IsBlockedAbonentQuery(args.Msisdn);

            var status = await _mediator.Send(query);

            return new IsBlockedAbonentResult { Status = status };
        }
    }
}
