using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftMarket
{
    [HiveEngineContract("nftmarket", "changePrice")]
    public class HiveEngineNftMarketChangePriceModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("nfts")] public NumberOrStringModel[] Nfts { get; }
        [JsonPropertyName("price")] public DecimalOrStringModel Price { get; }

        public HiveEngineNftMarketChangePriceModel(string symbol, NumberOrStringModel[] nfts, DecimalOrStringModel price)
        {
            Symbol = symbol;
            Nfts = nfts;
            Price = price;
        }
    }
}