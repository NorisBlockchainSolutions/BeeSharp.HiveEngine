using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftMarket
{
    [HiveEngineContract("nftmarket", "enableMarket")]
    public class HiveEngineNftMarketEnableMarketModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }

        public HiveEngineNftMarketEnableMarketModel(string symbol)
        {
            Symbol = symbol;
        }
    }
}