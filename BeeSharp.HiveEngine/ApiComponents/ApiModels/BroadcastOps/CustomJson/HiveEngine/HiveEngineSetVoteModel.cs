using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.BroadcastOps.CustomJson;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine
{
    [CustomJsonOpId("scot_set_vote", typeof(ObjectListOrObjectWrapperModel<HiveEngineSetVoteModel>))]
    public class HiveEngineSetVoteModel
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("vote_weight_multiplier")]
        public DecimalOrStringModel VoteWeightMultiplier { get; }

        public HiveEngineSetVoteModel(string symbol, DecimalOrStringModel voteWeightMultiplier)
        {
            Symbol = symbol;
            VoteWeightMultiplier = voteWeightMultiplier;
        }
    }
}