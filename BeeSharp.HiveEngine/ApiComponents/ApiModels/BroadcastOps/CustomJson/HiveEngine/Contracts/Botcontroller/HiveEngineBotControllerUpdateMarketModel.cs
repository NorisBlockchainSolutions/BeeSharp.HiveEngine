using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Botcontroller
{
    [HiveEngineContract("botcontroller", "updateMarket")]
    public class HiveEngineBotControllerUpdateMarketModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("minSpread")] public DecimalOrStringModel MinSpread { get; }

        public HiveEngineBotControllerUpdateMarketModel(string symbol, DecimalOrStringModel minSpread)
        {
            Symbol = symbol;
            MinSpread = minSpread;
        }
    }
}