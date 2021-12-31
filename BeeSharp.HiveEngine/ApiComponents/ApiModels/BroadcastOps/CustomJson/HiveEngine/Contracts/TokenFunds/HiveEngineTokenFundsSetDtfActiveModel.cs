using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.TokenFunds
{
    [HiveEngineContract("tokenfunds", "setDtfActive")]
    public class HiveEngineTokenFundsSetDtfActiveModel : HiveEngineOperation
    {
        [JsonPropertyName("fundId")] public string FundId { get; }
        [JsonPropertyName("active")] public bool Active { get; }

        public HiveEngineTokenFundsSetDtfActiveModel(string fundId, bool active)
        {
            FundId = fundId;
            Active = active;
        }
    }
}