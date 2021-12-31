using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Distribution
{
    [HiveEngineContract("distribution", "flush")]
    public class HiveEngineDistributionFlushModel : HiveEngineOperation
    {
        [JsonPropertyName("id")] public int Id { get; }

        public HiveEngineDistributionFlushModel(int id)
        {
            Id = id;
        }
    }
}