using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftAuction
{
    [HiveEngineContract("nftauction", "cancel")]
    public class HiveEngineNftAuctionCancelModel : HiveEngineOperation
    {
        [JsonPropertyName("auctionId")] public string AuctionId { get; }

        public HiveEngineNftAuctionCancelModel(string auctionId)
        {
            AuctionId = auctionId;
        }
    }
}