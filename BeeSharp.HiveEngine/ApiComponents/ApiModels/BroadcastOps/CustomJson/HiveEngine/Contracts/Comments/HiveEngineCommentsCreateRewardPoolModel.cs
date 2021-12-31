using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Comments
{
    [HiveEngineContract("comments", "createRewardPool")]
    public class HiveEngineCommentsCreateRewardPoolModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("config")] public HiveEngineCommentsRewardPoolConfigModel Config { get; }

        public HiveEngineCommentsCreateRewardPoolModel(string symbol, HiveEngineCommentsRewardPoolConfigModel config)
        {
            Symbol = symbol;
            Config = config;
        }
    }

    public class HiveEngineCommentsRewardPoolConfigModel
    {
        [JsonPropertyName("postRewardCurve")] public string PostRewardCurve { get; }

        [JsonPropertyName("postRewardCurveParameter")]
        public string PostRewardCurveParameter { get; }

        [JsonPropertyName("curationRewardCurve")]
        public string CurationRewardCurve { get; }

        [JsonPropertyName("curationRewardCurveParameter")]
        public string CurationRewardCurveParameter { get; }

        [JsonPropertyName("curationRewardPercentage")]
        public int CurationRewardPercentage { get; }

        [JsonPropertyName("cashoutWindowDays")]
        public int CashoutWindowDays { get; }

        [JsonPropertyName("rewardPerInterval")]
        public string RewardPerInterval { get; }

        [JsonPropertyName("rewardIntervalSeconds")]
        public int RewardIntervalSeconds { get; }

        [JsonPropertyName("voteRegenerationDays")]
        public int VoteRegenerationDays { get; }

        [JsonPropertyName("downvoteRegenerationDays")]
        public int DownvoteRegenerationDays { get; }

        [JsonPropertyName("stakedRewardPercentage")]
        public int StakedRewardPercentage { get; }

        [JsonPropertyName("votePowerConsumption")]
        public int VotePowerConsumption { get; }

        [JsonPropertyName("downvotePowerConsumption")]
        public int DownvotePowerConsumption { get; }

        [JsonPropertyName("tags")] public string[] Tags { get; }

        public HiveEngineCommentsRewardPoolConfigModel(string postRewardCurve, string postRewardCurveParameter,
            string curationRewardCurve, string curationRewardCurveParameter, int curationRewardPercentage,
            int cashoutWindowDays, string rewardPerInterval, int rewardIntervalSeconds, int voteRegenerationDays,
            int downvoteRegenerationDays, int stakedRewardPercentage, int votePowerConsumption,
            int downvotePowerConsumption, string[] tags)
        {
            PostRewardCurve = postRewardCurve;
            PostRewardCurveParameter = postRewardCurveParameter;
            CurationRewardCurve = curationRewardCurve;
            CurationRewardCurveParameter = curationRewardCurveParameter;
            CurationRewardPercentage = curationRewardPercentage;
            CashoutWindowDays = cashoutWindowDays;
            RewardPerInterval = rewardPerInterval;
            RewardIntervalSeconds = rewardIntervalSeconds;
            VoteRegenerationDays = voteRegenerationDays;
            DownvoteRegenerationDays = downvoteRegenerationDays;
            StakedRewardPercentage = stakedRewardPercentage;
            VotePowerConsumption = votePowerConsumption;
            DownvotePowerConsumption = downvotePowerConsumption;
            Tags = tags;
        }
    }
}