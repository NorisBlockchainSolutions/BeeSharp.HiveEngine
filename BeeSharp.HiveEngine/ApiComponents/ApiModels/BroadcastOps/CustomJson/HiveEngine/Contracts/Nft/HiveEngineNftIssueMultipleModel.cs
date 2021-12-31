using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "issueMultiple")]
    public class HiveEngineNftIssueMultipleModel : HiveEngineOperation
    {
        [JsonPropertyName("instances")] public HiveEngineNftIssueModel[] Instances { get; }

        public HiveEngineNftIssueMultipleModel(HiveEngineNftIssueModel[] instances)
        {
            Instances = instances;
        }
    }
}