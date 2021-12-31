using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "transfer")]
    public class HiveEngineNftTransferModel : HiveEngineOperation
    {
        [JsonPropertyName("nfts")] public HiveEngineNftModel[] Nfts { get; }
        [JsonPropertyName("to")] public string To { get; }
        [JsonPropertyName("toType")] public string? ToType { get; }
        [JsonPropertyName("memo")] public object? Memo { get; }

        public HiveEngineNftTransferModel(HiveEngineNftModel[] nfts, string to, string? toType = null,
            object? memo = null)
        {
            Nfts = nfts;
            To = to;
            ToType = toType;
            Memo = memo;
        }
    }
}