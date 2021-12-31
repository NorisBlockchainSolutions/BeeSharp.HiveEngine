using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Mining
{
    [HiveEngineContract("mining", "setActive")]
    public class HiveEngineMiningSetActiveModel : HiveEngineOperation
    {
        [JsonPropertyName("id")] public string Id { get; }
        [JsonPropertyName("active")] public bool Active { get; }

        public HiveEngineMiningSetActiveModel(string id, bool active)
        {
            Id = id;
            Active = active;
        }
    }
}