using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftMarket
{
    [HiveEngineContract("nftmarket", "cancel")]
    public class HiveEngineNftMarketCancelModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("nfts")] public NumberOrStringModel[] Nfts { get; }

        public HiveEngineNftMarketCancelModel(string symbol, NumberOrStringModel[] nfts)
        {
            Symbol = symbol;
            Nfts = nfts;
        }
    }
}