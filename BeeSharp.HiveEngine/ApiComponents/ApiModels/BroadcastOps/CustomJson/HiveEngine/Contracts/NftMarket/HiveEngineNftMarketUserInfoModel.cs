using System.Text.Json.Serialization;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftMarket
{
    public class HiveEngineNftMarketUserInfoModel : HiveEngineOperation
    {
        [JsonPropertyName("user")] public string User { get; }
        [JsonPropertyName("bid_id")] public string BidId { get; }

        public HiveEngineNftMarketUserInfoModel(string user, string bidId)
        {
            User = user;
            BidId = bidId;
        }
    }
}