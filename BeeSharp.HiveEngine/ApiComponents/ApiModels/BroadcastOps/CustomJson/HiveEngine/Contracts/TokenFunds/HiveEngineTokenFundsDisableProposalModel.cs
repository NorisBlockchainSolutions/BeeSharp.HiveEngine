using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.TokenFunds
{
    [HiveEngineContract("tokenfunds", "disableProposal")]
    public class HiveEngineTokenFundsDisableProposalModel : HiveEngineOperation
    {
        [JsonPropertyName("id")] public string Id { get; }

        public HiveEngineTokenFundsDisableProposalModel(string id)
        {
            Id = id;
        }
    }
}