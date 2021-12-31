using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Distribution
{
    [HiveEngineContract("distribution", "setActive")]
    public class HiveEngineDistributionSetActiveModel : HiveEngineOperation
    {
        [JsonPropertyName("id")] public int Id { get; }

        [JsonPropertyName("active")] public bool Active { get; }

        public HiveEngineDistributionSetActiveModel(int id, bool active)
        {
            Id = id;
            Active = active;
        }
    }
}