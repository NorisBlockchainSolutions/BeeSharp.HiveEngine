using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Botcontroller
{
    [HiveEngineContract("botcontroller", "enableMarket")]
    public class HiveEngineBotControllerEnableMarketModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }

        public HiveEngineBotControllerEnableMarketModel(string symbol)
        {
            Symbol = symbol;
        }
    }
}