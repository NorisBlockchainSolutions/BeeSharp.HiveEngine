using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "updateMetadata")]
    public class HiveEngineNftUpdateMetadataModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("metadata")] public object Metadata { get; }

        public HiveEngineNftUpdateMetadataModel(string symbol, object metadata)
        {
            Symbol = symbol;
            Metadata = metadata;
        }
    }
}