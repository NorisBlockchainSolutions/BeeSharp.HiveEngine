using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftAuction
{
    [HiveEngineContract("nftauction", "cancelBid")]
    public class HiveEngineNftAuctionCancelBidModel : HiveEngineOperation
    {
        [JsonPropertyName("auctionId")] public string AuctionId { get; }

        public HiveEngineNftAuctionCancelBidModel(string auctionId)
        {
            AuctionId = auctionId;
        }
    }
}