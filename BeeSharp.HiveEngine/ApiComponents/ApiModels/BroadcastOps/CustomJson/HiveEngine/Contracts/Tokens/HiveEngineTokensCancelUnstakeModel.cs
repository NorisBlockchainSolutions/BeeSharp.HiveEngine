using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "cancelUnstake")]
    public class HiveEngineTokensCancelUnstakeModel : HiveEngineOperation
    {
        [JsonPropertyName("txID")] public string TxId { get; }

        public HiveEngineTokensCancelUnstakeModel(string txId)
        {
            TxId = txId;
        }
    }
}