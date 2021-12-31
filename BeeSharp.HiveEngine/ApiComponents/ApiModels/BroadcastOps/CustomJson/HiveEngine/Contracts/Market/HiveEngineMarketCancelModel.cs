using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Market
{
    [HiveEngineContract("market", "cancel")]
    public class HiveEngineMarketCancelModel : HiveEngineOperation
    {
        [JsonPropertyName("type")] public string Type { get; }
        [JsonPropertyName("id")] public NumberOrStringModel Id { get; }

        public HiveEngineMarketCancelModel(string type, NumberOrStringModel id)
        {
            Type = type;
            Id = id;
        }
    }
}