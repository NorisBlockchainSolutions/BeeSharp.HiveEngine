using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Mining
{
    [HiveEngineContract("mining", "createPool")]
    public class HiveEngineMiningCreatePoolModel : HiveEngineOperation
    {
        [JsonPropertyName("lotteryWinners")] public uint LotteryWinners { get; }

        [JsonPropertyName("lotteryIntervalHours")]
        public uint LotteryIntervalHours { get; }

        [JsonPropertyName("lotteryAmount")] public string LotteryAmount { get; }
        [JsonPropertyName("minedToken")] public string MinedToken { get; }

        [JsonPropertyName("tokenMiners")] public HiveEngineTokenMinersModel[] TokenMiners { get; }

        public HiveEngineMiningCreatePoolModel(uint lotteryWinners, uint lotteryIntervalHours, string lotteryAmount,
            string minedToken, HiveEngineTokenMinersModel[] tokenMiners)
        {
            LotteryWinners = lotteryWinners;
            LotteryIntervalHours = lotteryIntervalHours;
            LotteryAmount = lotteryAmount;
            MinedToken = minedToken;
            TokenMiners = tokenMiners;
        }
    }

    public class HiveEngineTokenMinersModel
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("multiplier")] public uint Multiplier { get; }

        public HiveEngineTokenMinersModel(string symbol, uint multiplier)
        {
            Symbol = symbol;
            Multiplier = multiplier;
        }
    }
}