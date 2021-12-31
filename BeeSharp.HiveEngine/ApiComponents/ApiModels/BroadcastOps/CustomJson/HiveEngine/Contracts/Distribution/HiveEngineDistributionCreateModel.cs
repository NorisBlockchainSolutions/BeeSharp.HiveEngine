using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Distribution
{
    [HiveEngineContract("distribution", "create")]
    public class HiveEngineDistributionCreateModel : HiveEngineOperation
    {
        [JsonPropertyName("strategy")] public string Strategy { get; }
        [JsonPropertyName("numTicks")] public string NumTicks { get; }
        [JsonPropertyName("tokenPair")] public string TokenPair { get; }
        [JsonPropertyName("excludeAccount")] public string[] ExcludeAccount { get; }
        [JsonPropertyName("bonusCurve")] public HiveEngineDistributionBonusCurveModel BonusCurve { get; }

        public HiveEngineDistributionCreateModel(string strategy, string numTicks, string tokenPair,
            string[] excludeAccount, HiveEngineDistributionBonusCurveModel bonusCurve)
        {
            Strategy = strategy;
            NumTicks = numTicks;
            TokenPair = tokenPair;
            ExcludeAccount = excludeAccount;
            BonusCurve = bonusCurve;
        }
    }

    public class HiveEngineDistributionBonusCurveModel
    {
        [JsonPropertyName("numPeriods")] public string NumPeriods { get; }
        [JsonPropertyName("periodBonusPct")] public string PeriodBonusPct { get; }

        public HiveEngineDistributionBonusCurveModel(string numPeriods, string periodBonusPct)
        {
            NumPeriods = numPeriods;
            PeriodBonusPct = periodBonusPct;
        }
    }
}