using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Distribution
{
    [HiveEngineContract("distribution", "deposit")]
    public class HiveEngineDistributionDepositModel : HiveEngineOperation
    {
        [JsonPropertyName("id")] public NumberOrStringModel Id { get; }
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("quantity")] public NumberOrStringModel Quantity { get; }

        public HiveEngineDistributionDepositModel(NumberOrStringModel id, string symbol, NumberOrStringModel quantity)
        {
            Id = id;
            Symbol = symbol;
            Quantity = quantity;
        }
    }
}