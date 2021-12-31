using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "enableDelegation")]
    public class HiveEngineTokensEnableDelegationModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("undelegationCooldown")]
        public int UndelegationCooldown { get; }

        public HiveEngineTokensEnableDelegationModel(string symbol, int undelegationCooldown)
        {
            Symbol = symbol;
            UndelegationCooldown = undelegationCooldown;
        }
    }
}