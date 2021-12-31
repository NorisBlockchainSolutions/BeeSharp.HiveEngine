using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.MarketPools
{
    [HiveEngineContract("marketpools", "setRewardPoolActive")]
    public class HiveEngineMarketPoolsSetRewardPoolActiveModel : HiveEngineOperation
    {
        [JsonPropertyName("tokenPair")] public string TokenPair { get; }
        [JsonPropertyName("minedToken")] public string MinedToken { get; }
        [JsonPropertyName("active")] public bool Active { get; }

        public HiveEngineMarketPoolsSetRewardPoolActiveModel(string tokenPair, string minedToken, bool active)
        {
            TokenPair = tokenPair;
            MinedToken = minedToken;
            Active = active;
        }
    }
}