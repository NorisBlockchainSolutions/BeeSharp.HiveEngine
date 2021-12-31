using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "undelegate")]
    public class HiveEngineTokensUndelegateModel : HiveEngineOperation
    {
        [JsonPropertyName("from")] public string From { get; }
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("quantity")] public DecimalOrStringModel Quantity { get; }

        public HiveEngineTokensUndelegateModel(string from, string symbol, DecimalOrStringModel quantity)
        {
            From = from;
            Symbol = symbol;
            Quantity = quantity;
        }
    }
}