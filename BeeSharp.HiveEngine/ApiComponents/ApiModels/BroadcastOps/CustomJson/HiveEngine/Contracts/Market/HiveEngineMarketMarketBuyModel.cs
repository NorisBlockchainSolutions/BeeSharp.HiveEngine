using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Market
{
    [HiveEngineContract("market", "marketBuy")]
    public class HiveEngineMarketMarketBuyModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("to")] public string? To { get; }
        [JsonPropertyName("quantity")] public DecimalOrStringModel Quantity { get; }
        [JsonPropertyName("memo")] public NumberOrStringModel? Memo { get; }

        public HiveEngineMarketMarketBuyModel(string symbol, string? to, DecimalOrStringModel quantity,
            NumberOrStringModel? memo = null)
        {
            Symbol = symbol;
            To = to;
            Quantity = quantity;
            Memo = memo;
        }
    }
}