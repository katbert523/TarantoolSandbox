using ApplicationSystem.Application;
using ProGaudi.Tarantool.Client;
using ProGaudi.Tarantool.Client.Model;


namespace ApplicationSystem.Infrastructure
{
    /// <inheritdoc cref="ICDRService"/>
    public class CDRService : ICDRService
    {
        private const string CreateCallDataRecord = "create_call_data_record";

        public async Task CreateCDR(long senderMsisdn, long receiverMsisdn, DateTime eventDate)
        {
            var box = await Box.Connect("127.0.0.1:3301");

            await box.Call(CreateCallDataRecord,
                new TarantoolTuple<long, long, string>(senderMsisdn, receiverMsisdn, eventDate.ToString()));
        }
    }
}
