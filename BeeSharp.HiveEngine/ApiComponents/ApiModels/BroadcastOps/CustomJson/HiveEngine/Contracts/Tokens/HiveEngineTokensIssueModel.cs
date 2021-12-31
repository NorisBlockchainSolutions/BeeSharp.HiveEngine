using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "issue")]
    public class HiveEngineTokensIssueModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("to")] public string To { get; }
        [JsonPropertyName("quantity")] public DecimalOrStringModel Quantity { get; }

        public HiveEngineTokensIssueModel(string symbol, string to, DecimalOrStringModel quantity)
        {
            Symbol = symbol;
            To = to;
            Quantity = quantity;
        }
    }
}