using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftAuction
{
    [HiveEngineContract("nftauction", "bid")]
    public class HiveEngineNftAuctionBidModel : HiveEngineOperation
    {
        [JsonPropertyName("auctionId")] public string AuctionId { get; }
        [JsonPropertyName("bid")] public NumberOrStringModel Bid { get; }
        [JsonPropertyName("marketAccount")] public string MarketAccount { get; }

        public HiveEngineNftAuctionBidModel(string auctionId, NumberOrStringModel bid, string marketAccount)
        {
            AuctionId = auctionId;
            Bid = bid;
            MarketAccount = marketAccount;
        }
    }
}