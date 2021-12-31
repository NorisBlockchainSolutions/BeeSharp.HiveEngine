using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "updateName")]
    public class HiveEngineNftUpdateNameModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("name")] public string Name { get; }

        public HiveEngineNftUpdateNameModel(string symbol, string name)
        {
            Symbol = symbol;
            Name = name;
        }
    }
}