using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftMarket
{
    [HiveEngineContract("nftmarket", "sell")]
    public class HiveEngineNftMarketSellModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("nfts")] public NumberOrStringModel[] Nfts { get; }
        [JsonPropertyName("price")] public NumberOrStringModel Price { get; }
        [JsonPropertyName("priceSymbol")] public string PriceSymbol { get; }
        [JsonPropertyName("fee")] public long Fee { get; }

        public HiveEngineNftMarketSellModel(string symbol, NumberOrStringModel[] nfts, NumberOrStringModel price,
            string priceSymbol, long fee)
        {
            Symbol = symbol;
            Nfts = nfts;
            Price = price;
            PriceSymbol = priceSymbol;
            Fee = fee;
        }
    }
}