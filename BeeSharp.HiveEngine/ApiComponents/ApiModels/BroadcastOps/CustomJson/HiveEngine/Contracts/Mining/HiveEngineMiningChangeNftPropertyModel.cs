using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Mining
{
    [HiveEngineContract("mining", "changeNftProperty")]
    public class HiveEngineMiningChangeNftPropertyModel : HiveEngineOperation
    {
        [JsonPropertyName("id")] public string Id { get; }
        [JsonPropertyName("type")] public string Type { get; }
        [JsonPropertyName("propertyName")] public string PropertyName { get; }
        [JsonPropertyName("changeAmount")] public DecimalOrStringModel ChangeAmount { get; }

        public HiveEngineMiningChangeNftPropertyModel(string id, string type, string propertyName,
            DecimalOrStringModel changeAmount)
        {
            Id = id;
            Type = type;
            PropertyName = propertyName;
            ChangeAmount = changeAmount;
        }
    }
}