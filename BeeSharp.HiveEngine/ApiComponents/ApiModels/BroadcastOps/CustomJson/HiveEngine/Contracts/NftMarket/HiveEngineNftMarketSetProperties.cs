using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftMarket
{
    [HiveEngineContract("nft", "setProperties")]
    public class HiveEngineNftMarketSetProperties : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("nfts")] public object Nfts { get; }

        public HiveEngineNftMarketSetProperties(string symbol, object nfts)
        {
            Symbol = symbol;
            Nfts = nfts;
        }
    }
}