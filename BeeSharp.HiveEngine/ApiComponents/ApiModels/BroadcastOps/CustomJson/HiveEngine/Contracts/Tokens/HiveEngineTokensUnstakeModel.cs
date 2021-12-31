using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "unstake")]
    public class HiveEngineTokensUnstakeModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("quantity")] public DecimalOrStringModel Quantity { get; }

        public HiveEngineTokensUnstakeModel(string symbol, DecimalOrStringModel quantity)
        {
            Symbol = symbol;
            Quantity = quantity;
        }
    }
}