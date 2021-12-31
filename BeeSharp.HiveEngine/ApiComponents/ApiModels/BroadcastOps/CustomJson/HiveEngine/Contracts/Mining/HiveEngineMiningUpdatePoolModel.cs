using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Mining
{
    [HiveEngineContract("mining", "updatePool")]
    public class HiveEngineMiningUpdatePoolModel : HiveEngineOperation
    {
        [JsonPropertyName("id")] public string Id { get; }

        [JsonPropertyName("lotteryWinners")] public uint LotteryWinners { get; }

        [JsonPropertyName("lotteryIntervalHours")]
        public uint LotteryIntervalHours { get; }

        [JsonPropertyName("lotteryAmount")] public string LotteryAmount { get; }

        [JsonPropertyName("tokenMiners")] public HiveEngineTokenMinersModel[] TokenMiners { get; }

        public HiveEngineMiningUpdatePoolModel(string id, uint lotteryWinners, uint lotteryIntervalHours,
            string lotteryAmount, HiveEngineTokenMinersModel[] tokenMiners)
        {
            Id = id;
            LotteryWinners = lotteryWinners;
            LotteryIntervalHours = lotteryIntervalHours;
            LotteryAmount = lotteryAmount;
            TokenMiners = tokenMiners;
        }
    }
}