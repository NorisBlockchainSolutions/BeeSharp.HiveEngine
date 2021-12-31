using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "transferOwnership")]
    public class HiveEngineTokensTransferOwnershipModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("to")] public string To { get; }

        public HiveEngineTokensTransferOwnershipModel(string symbol, string to)
        {
            Symbol = symbol;
            To = to;
        }
    }
}