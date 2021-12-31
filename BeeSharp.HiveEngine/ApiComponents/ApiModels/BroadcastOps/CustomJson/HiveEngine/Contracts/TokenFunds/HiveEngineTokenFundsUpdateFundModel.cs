using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.TokenFunds
{
    [HiveEngineContract("tokenfunds", "updateFund")]
    public class HiveEngineTokenFundsUpdateFundModel : HiveEngineOperation
    {
        [JsonPropertyName("fundId")] public string FundId { get; }
        [JsonPropertyName("voteThreshold")] public string VoteThreshold { get; }
        [JsonPropertyName("maxDays")] public string MaxDays { get; }
        [JsonPropertyName("maxAmountPerDay")] public string MaxAmountPerDay { get; }
        [JsonPropertyName("proposalFee")] public HiveEngineTokenFundsProposalFeeModel ProposalFee { get; }

        public HiveEngineTokenFundsUpdateFundModel(string fundId, string voteThreshold, string maxDays,
            string maxAmountPerDay, HiveEngineTokenFundsProposalFeeModel proposalFee)
        {
            FundId = fundId;
            VoteThreshold = voteThreshold;
            MaxDays = maxDays;
            MaxAmountPerDay = maxAmountPerDay;
            ProposalFee = proposalFee;
        }
    }
}