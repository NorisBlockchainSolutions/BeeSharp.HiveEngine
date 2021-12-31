using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "updatePropertyDefinition")]
    public class HiveEngineNftUpdatePropertyDefinitionModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("name")] public string Name { get; }
        [JsonPropertyName("type")] public string Type { get; }
        [JsonPropertyName("isReadOnly")] public bool IsReadOnly { get; }

        public HiveEngineNftUpdatePropertyDefinitionModel(string symbol, string name, string type, bool isReadOnly)
        {
            Symbol = symbol;
            Name = name;
            Type = type;
            IsReadOnly = isReadOnly;
        }
    }
}