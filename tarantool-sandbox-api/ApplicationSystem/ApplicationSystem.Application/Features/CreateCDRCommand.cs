using MediatR;

namespace ApplicationSystem.Application.Features
{
    /// <summary>
    /// Команда на резервацию.
    /// </summary>
    public class CreateCDRCommand : IRequest
    {
        /// <summary>
        /// Номер вызывающего абонента.
        /// </summary>
        public long SenderMsisdn { get; init; }

        /// <summary>
        /// Номер абонента, принимающего звонок.
        /// </summary>
        public long ReceiverMsisdn { get; init; }

        /// <summary>
        /// Дата события.
        /// </summary>
        public DateTime EventDate { get; init; }

        public CreateCDRCommand(long senderMsisdn, long receiverMsisdn, DateTime eventDate)
        {
            SenderMsisdn = senderMsisdn;
            ReceiverMsisdn = receiverMsisdn;
            EventDate = eventDate;
        }
    }
}
