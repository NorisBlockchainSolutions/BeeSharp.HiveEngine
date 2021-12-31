using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "updateMetadata")]
    public class HiveEngineTokensUpdateMetadataModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("metadata")] public HiveEngineTokensMetadataModel Metadata { get; }

        public HiveEngineTokensUpdateMetadataModel(string symbol, HiveEngineTokensMetadataModel metadata)
        {
            Symbol = symbol;
            Metadata = metadata;
        }
    }

    public class HiveEngineTokensMetadataModel
    {
        [JsonPropertyName("url")] public string Url { get; }
        [JsonPropertyName("icon")] public string Icon { get; }
        [JsonPropertyName("desc")] public string Description { get; }

        public HiveEngineTokensMetadataModel(string url, string icon, string description)
        {
            Url = url;
            Icon = icon;
            Description = description;
        }
    }
}