using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "setGroupBy")]
    public class HiveEngineNftSetGroupByModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("properties")] public string[] Properties { get; }

        public HiveEngineNftSetGroupByModel(string symbol, string[] properties)
        {
            Symbol = symbol;
            Properties = properties;
        }
    }
}