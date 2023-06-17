using MediatR;

namespace ApplicationSystem.Application.Features
{
    public class IsBlockedAbonentHandler : IRequestHandler<IsBlockedAbonentQuery, bool>
    {
        private readonly IBlockInfoAbonentsService _blockInfoAbonentsService;

        public IsBlockedAbonentHandler(IBlockInfoAbonentsService blockInfoAbonentsService)
        {
            _blockInfoAbonentsService = blockInfoAbonentsService;
        }

        public async Task<bool> Handle(IsBlockedAbonentQuery request, CancellationToken cancellationToken)
        {
            var isBlockedAbonent = await _blockInfoAbonentsService.IsBlockedAbonent(request.Msisdn);

            return isBlockedAbonent;
        }
    }
}
