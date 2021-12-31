using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Distribution
{
    [HiveEngineContract("distribution", "update")]
    public class HiveEngineDistributionUpdateModel : HiveEngineOperation
    {
        [JsonPropertyName("id")] public int Id { get; }
        [JsonPropertyName("tokenPair")] public string TokenPair { get; }
        [JsonPropertyName("excludeAccount")] public string[] ExcludeAccount { get; }
        [JsonPropertyName("bonusCurve")] public HiveEngineDistributionBonusCurveModel BonusCurve { get; }

        public HiveEngineDistributionUpdateModel(int id, string tokenPair, string[] excludeAccount,
            HiveEngineDistributionBonusCurveModel bonusCurve)
        {
            Id = id;
            TokenPair = tokenPair;
            ExcludeAccount = excludeAccount;
            BonusCurve = bonusCurve;
        }
    }
}