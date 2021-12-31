using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.TokenFunds
{
    [HiveEngineContract("tokenfunds", "disapproveProposal")]
    public class HiveEngineTokenFundsDisapproveProposalModel : HiveEngineOperation
    {
        [JsonPropertyName("id")] public string Id { get; }

        public HiveEngineTokenFundsDisapproveProposalModel(string id)
        {
            Id = id;
        }
    }
}