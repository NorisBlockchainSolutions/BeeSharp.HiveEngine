using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Comments
{
    [HiveEngineContract("comments", "setActive")]
    public class HiveEngineCommentsSetActiveModel : HiveEngineOperation
    {
        [JsonPropertyName("rewardPoolId")] public uint RewardPoolId { get; }
        [JsonPropertyName("active")] public bool Active { get; }

        public HiveEngineCommentsSetActiveModel(uint rewardPoolId, bool active)
        {
            RewardPoolId = rewardPoolId;
            Active = active;
        }
    }
}