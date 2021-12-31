using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.MarketPools
{
    [HiveEngineContract("marketpools", "createRewardPool")]
    public class HiveEngineMarketPoolsCreateRewardPoolModel : HiveEngineOperation
    {
        [JsonPropertyName("tokenPair")] public string TokenPair { get; }
        [JsonPropertyName("lotteryWinners")] public uint LotteryWinners { get; }

        [JsonPropertyName("lotteryIntervalHours")]
        public uint LotteryIntervalHours { get; }

        [JsonPropertyName("lotteryAmount")] public string LotteryAmount { get; }
        [JsonPropertyName("minedToken")] public string MinedToken { get; }

        public HiveEngineMarketPoolsCreateRewardPoolModel(string tokenPair, uint lotteryWinners,
            uint lotteryIntervalHours, string lotteryAmount, string minedToken)
        {
            TokenPair = tokenPair;
            LotteryWinners = lotteryWinners;
            LotteryIntervalHours = lotteryIntervalHours;
            LotteryAmount = lotteryAmount;
            MinedToken = minedToken;
        }
    }
}