using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Comments
{
    [HiveEngineContract("comments", "updateRewardPool")]
    public class HiveEngineCommentsUpdateRewardPoolModel : HiveEngineOperation
    {
        [JsonPropertyName("config")] public HiveEngineCommentsRewardPoolConfigModel Config { get; }

        public HiveEngineCommentsUpdateRewardPoolModel(HiveEngineCommentsRewardPoolConfigModel config)
        {
            Config = config;
        }
    }
}