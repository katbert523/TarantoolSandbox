using MediatR;

namespace ApplicationSystem.Application.Features
{
    /// <summary>
    /// Запрос на проверку блокировки на абоненте.
    /// </summary>
    public class IsBlockedAbonentQuery : IRequest<bool>
    {
        /// <summary>
        /// Msisdn абонента.
        /// </summary>
        public long Msisdn { get; init; }

        public IsBlockedAbonentQuery(long msisdn)
        {
            Msisdn = msisdn;
        }
    }
}
