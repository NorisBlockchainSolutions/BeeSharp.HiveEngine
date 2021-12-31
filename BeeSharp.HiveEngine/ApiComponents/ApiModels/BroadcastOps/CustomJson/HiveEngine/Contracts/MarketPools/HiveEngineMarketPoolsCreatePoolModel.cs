using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.MarketPools
{
    [HiveEngineContract("marketpools", "createPool")]
    public class HiveEngineMarketPoolsCreatePoolModel : HiveEngineOperation
    {
        [JsonPropertyName("tokenPair")] public string TokenPair { get; }

        public HiveEngineMarketPoolsCreatePoolModel(string tokenPair)
        {
            TokenPair = tokenPair;
        }
    }
}