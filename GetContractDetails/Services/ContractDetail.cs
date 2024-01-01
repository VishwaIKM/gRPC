using Grpc.Core;

namespace GetContractDetails.Services
{
    public class ContractDetail : ContractDetails.ContractDetailsBase
    {
        private readonly ILogger<ContractDetail> _logger;

        public ContractDetail(ILogger<ContractDetail> logger)
        {
            _logger = logger;
        }

        public override Task<ContractModel> GetContractInfo(ContractLookUpModel request, ServerCallContext context)
        {
            ContractModel contract = new();
            if (request.Tokens ==111) { contract.Tokens = 111; contract.TradingSymbol = "NIFTY%)"; }

            return Task.FromResult(contract);
        }
    }
}
