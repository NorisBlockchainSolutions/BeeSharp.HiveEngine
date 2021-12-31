using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.TokenFunds
{
    [HiveEngineContract("tokenfunds", "createFund")]
    public class HiveEngineTokenFundsCreateFundModel : HiveEngineOperation
    {
        [JsonPropertyName("payToken")] public string PayToken { get; }
        [JsonPropertyName("voteToken")] public string VoteToken { get; }
        [JsonPropertyName("voteThreshold")] public string VoteThreshold { get; }
        [JsonPropertyName("maxDays")] public string MaxDays { get; }
        [JsonPropertyName("maxAmountPerDay")] public string MaxAmountPerDay { get; }
        [JsonPropertyName("proposalFee")] public HiveEngineTokenFundsProposalFeeModel ProposalFee { get; }

        public HiveEngineTokenFundsCreateFundModel(string payToken, string voteToken, string voteThreshold,
            string maxDays, string maxAmountPerDay, HiveEngineTokenFundsProposalFeeModel proposalFee)
        {
            PayToken = payToken;
            VoteToken = voteToken;
            VoteThreshold = voteThreshold;
            MaxDays = maxDays;
            MaxAmountPerDay = maxAmountPerDay;
            ProposalFee = proposalFee;
        }
    }

    public class HiveEngineTokenFundsProposalFeeModel
    {
        [JsonPropertyName("method")] public string Method { get; }
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("amount")] public string Amount { get; }

        public HiveEngineTokenFundsProposalFeeModel(string method, string symbol, string amount)
        {
            Method = method;
            Symbol = symbol;
            Amount = amount;
        }
    }
}