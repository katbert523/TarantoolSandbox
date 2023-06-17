using MediatR;

namespace ApplicationSystem.Application.Features
{
    public class CreateCDRHandler : IRequestHandler<CreateCDRCommand>
    {
        private readonly ICDRService _CDRService;

        public CreateCDRHandler(ICDRService cDRService)
        {
            _CDRService = cDRService;
        }

        public async Task<Unit> Handle(CreateCDRCommand request, CancellationToken cancellationToken)
        {
            await _CDRService.CreateCDR(request.SenderMsisdn, request.ReceiverMsisdn, request.EventDate);

            return Unit.Value;
        }
    }
}
