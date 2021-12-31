using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Witnesses
{
    [HiveEngineContract("witnesses", "proposeRound")]
    public class HiveEngineWitnessesProposeRoundModel : HiveEngineOperation
    {
        [JsonPropertyName("round")] public long Round { get; }
        [JsonPropertyName("roundHash")] public string RoundHash { get; }
        [JsonPropertyName("signatures")] public object[][] Signatures { get; }

        public HiveEngineWitnessesProposeRoundModel(long round, string roundHash, object[][] signatures)
        {
            Round = round;
            RoundHash = roundHash;
            Signatures = signatures;
        }
    }
}