using System;
using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftAuction
{
    [HiveEngineContract("nftauction", "create")]
    public class HiveEngineNftAuctionCreateModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("nfts")] public NumberOrStringModel[] Nfts { get; }
        [JsonPropertyName("minBid")] public NumberOrStringModel MinBid { get; }
        [JsonPropertyName("finalPrice")] public NumberOrStringModel FinalPrice { get; }
        [JsonPropertyName("priceSymbol")] public string PriceSymbol { get; }
        [JsonPropertyName("expiry")] public DateTime Expiry { get; }
        [JsonPropertyName("feePercent")] public ushort FeePercent { get; }

        public HiveEngineNftAuctionCreateModel(string symbol, NumberOrStringModel[] nfts, NumberOrStringModel minBid,
            NumberOrStringModel finalPrice, string priceSymbol, DateTime expiry, ushort feePercent)
        {
            Symbol = symbol;
            Nfts = nfts;
            MinBid = minBid;
            FinalPrice = finalPrice;
            PriceSymbol = priceSymbol;
            Expiry = expiry;
            FeePercent = feePercent;
        }
    }
}