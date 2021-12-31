using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "updatePrecision")]
    public class HiveEngineTokensUpdatePrecisionModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("precision")] public int Precision { get; }

        public HiveEngineTokensUpdatePrecisionModel(string symbol, int precision)
        {
            Symbol = symbol;
            Precision = precision;
        }
    }
}