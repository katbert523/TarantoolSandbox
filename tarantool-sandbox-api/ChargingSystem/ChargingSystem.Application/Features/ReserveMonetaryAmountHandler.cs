using MediatR;

namespace ChargingSystem.Application.Features
{
    public class ReserveMonetaryAmountHandler : IRequestHandler<ReserveMonetaryAmountCommand, bool>
    {
        private readonly IBalanceStorageService _balanceStorageService;

        public ReserveMonetaryAmountHandler(IBalanceStorageService balanceStorageService)
        {
            _balanceStorageService = balanceStorageService;
        }

        public async Task<bool> Handle(ReserveMonetaryAmountCommand request, CancellationToken cancellationToken)
        {
            var msisdn = request.Msisdn;

            var isSuccess = await _balanceStorageService.ReserveMonetaryAmount(msisdn);

            return isSuccess;
        }
    }
}
