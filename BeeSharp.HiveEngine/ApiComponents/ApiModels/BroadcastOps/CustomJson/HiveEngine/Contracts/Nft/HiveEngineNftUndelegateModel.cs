using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "undelegate")]
    public class HiveEngineNftUndelegateModel : HiveEngineOperation
    {
        [JsonPropertyName("nfts")] public HiveEngineNftModel[] Nfts { get; }

        public HiveEngineNftUndelegateModel(HiveEngineNftModel[] nfts)
        {
            Nfts = nfts;
        }
    }
}