using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.BroadcastOps.CustomJson;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "delegate")]
    public class HiveEngineNftDelegateModel : HiveEngineOperation
    {
        [JsonPropertyName("nfts")] public ObjectListOrObjectWrapperModel<HiveEngineNftModel> Nfts { get; }
        [JsonPropertyName("toType")] public string ToType { get; }
        [JsonPropertyName("to")] public string To { get; }

        public HiveEngineNftDelegateModel(ObjectListOrObjectWrapperModel<HiveEngineNftModel> nfts, string toType,
            string to)
        {
            Nfts = nfts;
            ToType = toType;
            To = to;
        }
    }
}