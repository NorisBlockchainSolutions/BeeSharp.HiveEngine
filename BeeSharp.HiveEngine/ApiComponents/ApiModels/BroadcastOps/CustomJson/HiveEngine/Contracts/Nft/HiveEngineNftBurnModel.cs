using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.BroadcastOps.CustomJson;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "burn")]
    public class HiveEngineNftBurnModel : HiveEngineOperation
    {
        [JsonPropertyName("nfts")] public ObjectListOrObjectWrapperModel<HiveEngineNftModel> Nfts { get; }

        public HiveEngineNftBurnModel(ObjectListOrObjectWrapperModel<HiveEngineNftModel> nfts)
        {
            Nfts = nfts;
        }
    }
}