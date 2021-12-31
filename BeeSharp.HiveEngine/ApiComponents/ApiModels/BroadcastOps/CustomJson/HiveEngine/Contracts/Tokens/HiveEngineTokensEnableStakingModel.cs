using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "enableStaking")]
    public class HiveEngineTokensEnableStakingModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("unstakingCooldown")]
        public int UnstakingCooldown { get; }
        [JsonPropertyName("numberTransactions")]
        public int NumberTransactions { get; }

        public HiveEngineTokensEnableStakingModel(string symbol, int unstakingCooldown, int numberTransactions)
        {
            Symbol = symbol;
            UnstakingCooldown = unstakingCooldown;
            NumberTransactions = numberTransactions;
        }
    }
}