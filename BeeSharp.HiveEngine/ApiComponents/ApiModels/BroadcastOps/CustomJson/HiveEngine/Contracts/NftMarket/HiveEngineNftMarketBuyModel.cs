using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftMarket
{
    [HiveEngineContract("nftmarket", "buy")]
    public class HiveEngineNftMarketBuyModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        // FIXME may appear as NumberOrStringModel[][], counter 1 so far
        [JsonPropertyName("nfts")] public NumberOrStringModel[] Nfts { get; }
        [JsonPropertyName("marketAccount")] public string MarketAccount { get; }
        [JsonPropertyName("expPrice")] public string ExpPrice { get; }
        [JsonPropertyName("expPriceSymbol")] public string ExpPriceSymbol { get; }
        [JsonPropertyName("memo")] public HiveEngineNftMarketUserInfoModel? Memo { get; }

        public HiveEngineNftMarketBuyModel(string symbol, NumberOrStringModel[] nfts, string marketAccount, string expPrice,
            string expPriceSymbol, HiveEngineNftMarketUserInfoModel? memo = null)
        {
            Symbol = symbol;
            Nfts = nfts;
            MarketAccount = marketAccount;
            ExpPrice = expPrice;
            ExpPriceSymbol = expPriceSymbol;
            Memo = memo;
        }
    }
}