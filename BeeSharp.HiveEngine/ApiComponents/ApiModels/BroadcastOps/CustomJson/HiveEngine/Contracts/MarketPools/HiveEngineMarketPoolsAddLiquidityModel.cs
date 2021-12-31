using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.MarketPools
{
    [HiveEngineContract("marketpools", "addLiquidity")]
    public class HiveEngineMarketPoolsAddLiquidityModel : HiveEngineOperation
    {
        [JsonPropertyName("tokenPair")] public string TokenPair { get; }
        [JsonPropertyName("baseQuantity")] public DecimalOrStringModel BaseQuantity { get; }
        [JsonPropertyName("quoteQuantity")] public DecimalOrStringModel QuoteQuantity { get; }

        public HiveEngineMarketPoolsAddLiquidityModel(string tokenPair, DecimalOrStringModel baseQuantity,
            DecimalOrStringModel quoteQuantity)
        {
            TokenPair = tokenPair;
            BaseQuantity = baseQuantity;
            QuoteQuantity = quoteQuantity;
        }
    }
}